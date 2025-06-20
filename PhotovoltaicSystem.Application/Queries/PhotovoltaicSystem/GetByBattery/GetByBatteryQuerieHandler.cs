using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;

namespace PhotovoltaicSystem.Application.Queries.PhotovoltaicSystem.GetByBattery
{
    public sealed class GetByBatteryQuerieHandler : IQueryHandler<GetByBatteryQuerie, IEnumerable<PhotovoltaicSystemInstall>>
    {
        private readonly IAppRepositoryManager _repository;
        public GetByBatteryQuerieHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<PhotovoltaicSystemInstall>>> Handle(GetByBatteryQuerie request, CancellationToken cancellationToken)
        {
            var result = await _repository.PhotovoltaicSystemInstall.GetByBattery(request.IsHasBattery);
            return Result.Ok<IEnumerable<PhotovoltaicSystemInstall>>(result);
        }
    }
}
