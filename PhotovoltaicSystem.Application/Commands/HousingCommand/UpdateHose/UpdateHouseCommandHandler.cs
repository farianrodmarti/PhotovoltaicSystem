using FluentResults;
using PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.UpdatePhotovoltaicSystem;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.UpdateHose
{
    public sealed class UpdateHouseCommandHandler : ICommandHandler<UpdateHouseCommand>
    {
        private readonly IAppRepositoryManager _repository;
        
        public UpdateHouseCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(UpdateHouseCommand request, CancellationToken cancellationToken)
        {
            await _repository.Housing.UpdateAsync(request.House);

            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
