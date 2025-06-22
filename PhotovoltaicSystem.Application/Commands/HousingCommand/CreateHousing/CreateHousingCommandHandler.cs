using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.CreateHousing
{
    public sealed class CreateHousingCommandHandler : ICommandHandler<CreateHousingCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public CreateHousingCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }
        public Task<Result> Handle(CreateHousingCommand request, CancellationToken cancellationToken)
        {
            Housing Housing = new Housing(request.HouseNumber, request.Address);
            /// no puedo crear algo q no existe
        }
    }
}
