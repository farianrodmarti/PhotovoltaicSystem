using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.InverterCommand.UpdateInverter
{
    public sealed class UpdateInverterCommandHandler : ICommandHandler<UpdateInverterCommand>
    {
        private readonly IAppRepositoryManager _repository;
        //private readonly IUnitOfWork _unitOfWork;
        public UpdateInverterCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }
        public async Task<Result> Handle(UpdateInverterCommand request, CancellationToken cancellationToken)
        {
            await _repository.Invert.UpdateAsync(request.Inverter);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
