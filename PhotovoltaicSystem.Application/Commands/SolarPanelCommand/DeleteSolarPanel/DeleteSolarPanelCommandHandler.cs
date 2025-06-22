using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.SolarPanelCommand.DeleteSolarPanel
{
    public sealed class DeleteSolarPanelCommandHandler : ICommandHandler<DeleteSolarPanelCommand>
    {
        private readonly IAppRepositoryManager _repository;
        public async Task<Result> Handle(DeleteSolarPanelCommand request, CancellationToken cancellationToken)
        {
            var solarPanel = await _repository.SolarPanel.GetBySerialNumber(request.SerialNumber);
            if (solarPanel == null)
                return Result.Fail("No se encontró un panel con ese número de serie.");
            _repository.SolarPanel.DeleteAsync(request.SerialNumber);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);
            return Result.Ok();


        }
    }
}
