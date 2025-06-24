using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.CreateHouse
{
    public sealed class CreateHouseCommandHandler : ICommandHandler<CreateHouseCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public CreateHouseCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }
        public async Task<Result> Handle(CreateHouseCommand request, CancellationToken cancellationToken)
        {
            House result = new House(request.HouseNumber, request.Address);

            await _repository.Housing.AddAsync(result);
            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();

        }
    }
}
