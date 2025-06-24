using FluentResults;
using PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.DeletePhotovoltaicSystem;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.DeleteHouse
{
    public sealed class DeleteHouseCommandHandler : ICommandHandler<DeleteHouseCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public async Task<Result> Handle(DeleteHouseCommand request, CancellationToken cancellationToken)
        {
            _repository.Housing.DeleteAsync(request.Address, request.HouseNumber);

            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
