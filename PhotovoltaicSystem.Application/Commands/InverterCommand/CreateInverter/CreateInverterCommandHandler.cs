using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.InverterCommand.CreateInverter
{
    public sealed class CreateInverterCommandHandler : ICommandHandler<CreateInverterCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public CreateInverterCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }
        public async Task<Result> Handle(CreateInverterCommand request, CancellationToken cancellationToken)
        {
            Inverter Inverter = new Inverter(
                request.Model,
                request.SerialNumber,
                request.MaximumPower);

            await _repository.Invert.AddAsync(Inverter);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return Result.Ok();
        }
    }
}
