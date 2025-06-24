using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.CreateBuilding
{
    public sealed class CreateBuildingCommandHandler : ICommandHandler<CreateBuildingCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public CreateBuildingCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            Building result = new Building(request.HouseNumber, request.Address, request.numberOfApartment);

            await _repository.Housing.AddAsync(result);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
