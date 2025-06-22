using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.InverterCommand.DeleteInverter
{
    public sealed class DeleteInverterCommandHandler : ICommandHandler<DeleteInverterCommand>
    {
        private readonly IAppRepositoryManager _repository;
        public async Task<Result> Handle(DeleteInverterCommand request, CancellationToken cancellationToken)
        {
            var Inverter = await _repository.Invert.GetBySpecificSerialNumber(request.SerialNumber);
            if (Inverter == null)
                return Result.Fail("No se encontró un inversor con ese número de serie.");
            _repository.Invert.DeleteAsync(request.SerialNumber);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return Result.Ok();
        }
    }
}
