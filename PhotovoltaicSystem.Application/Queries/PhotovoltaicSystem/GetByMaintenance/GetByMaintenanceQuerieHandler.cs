using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Application.Queries.PhotovoltaicSystem.GetByBattery;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Queries.PhotovoltaicSystem.GetByMaintenance
{
    public sealed class GetByMaintenanceQuerieHandler : IQueryHandler<GetByMaintenanceQuerie>, IEnumerable<PhotovoltaicSystemInstall>
    {
        private readonly IAppRepositoryManager _repository;
        public GetByMaintenanceQuerieHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }
        public async Task<Result<IEnumerable<PhotovoltaicSystemInstall>>> Handle(GetByMaintenanceQuerie request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.PhotovoltaicSystemInstall.GetByMaintenance<PhotovoltaicSystemInstall>());
        }
    }
}
