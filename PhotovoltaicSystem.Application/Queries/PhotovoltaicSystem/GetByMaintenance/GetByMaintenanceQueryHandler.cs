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
    public sealed class GetByMaintenanceQueryHandler : IQueryHandler<GetByMaintenanceQuery, IEnumerable<PhotovoltaicSystemInstall>>
    {
        private readonly IAppRepositoryManager _repository;
        public GetByMaintenanceQueryHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result<IEnumerable<PhotovoltaicSystemInstall>>> Handle(GetByMaintenanceQuery request, CancellationToken cancellationToken)
        {
            return await _repository.PhotovoltaicSystemInstall.GetByMaintenance(true);
        }
    }
}
