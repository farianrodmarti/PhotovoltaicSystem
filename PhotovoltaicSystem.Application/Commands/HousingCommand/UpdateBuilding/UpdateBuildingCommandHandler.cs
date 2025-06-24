using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.UpdateBuilding
{
    public sealed class UpdateBuildingCommandHandler : ICommandHandler<UpdateBuildingCommand>
    {
        private readonly IAppRepositoryManager _repository;
        public UpdateBuildingCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(UpdateBuildingCommand request, CancellationToken cancellationToken)
        {
            await _repository.Housing.UpdateAsync(request.Building);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
