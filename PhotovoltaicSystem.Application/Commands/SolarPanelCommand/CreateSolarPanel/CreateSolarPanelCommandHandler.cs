using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.SolarPanelCommand.CreateSolarPanel
{
    public sealed class CreateSolarPanelCommandHandler: ICommandHandler<CreateSolarPanelCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public CreateSolarPanelCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(CreateSolarPanelCommand request, CancellationToken cancellationToken)
        {
            SolarPanel SolarPanel = new SolarPanel(
                request.SerialNumber,
                request.Model,
                request.Capacity );
            
            await _repository.SolarPanel.AddAsync( SolarPanel );
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return Result.Ok();
        }
    }
}
