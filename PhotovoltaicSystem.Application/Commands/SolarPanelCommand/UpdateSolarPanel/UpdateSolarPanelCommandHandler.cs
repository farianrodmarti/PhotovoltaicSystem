using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PhotovoltaicSystem.Application.Commands.SolarPanelCommand.UpdateSolarPanel
{
    public sealed class UpdateSolarPanelCommandHandler : ICommandHandler<UpdateSolarPanelCommand>
    {
        private readonly IAppRepositoryManager _repository;
        //private readonly IUnitOfWork _unitOfWork;
        public UpdateSolarPanelCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }
        public async Task<Result> Handle(UpdateSolarPanelCommand request, CancellationToken cancellationToken)
        {
            await _repository.SolarPanel.UpdateAsync(request.SolarPanel);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
