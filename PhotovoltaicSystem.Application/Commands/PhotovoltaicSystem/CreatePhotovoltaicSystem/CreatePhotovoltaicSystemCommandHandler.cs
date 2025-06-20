using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;

namespace PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.CreatePhotovoltaicSystem
{
    public sealed class CreatePhotovoltaicSystemCommandHandler : ICommandHandler<CreatePhotovoltaicSystemCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public CreatePhotovoltaicSystemCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(CreatePhotovoltaicSystemCommand request, CancellationToken cancellationToken)
        {
            PhotovoltaicSystemInstall photovoltaicSystem = new PhotovoltaicSystemInstall(
                request.HasBattery,
                request.Inverter,
                request.SolarPanels
                );

            await _repository.PhotovoltaicSystemInstall.AddAsync(photovoltaicSystem);

            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
