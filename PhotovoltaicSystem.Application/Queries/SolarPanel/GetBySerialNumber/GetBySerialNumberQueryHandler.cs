using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using SolarPanels = PhotovoltaicSystem.Domain.Entities.SolarPanel;

namespace PhotovoltaicSystem.Application.Queries.SolarPanel.GetBySerialNumber
{
    public sealed class GetBySerialNumberQueryHandler : IQueryHandler<GetBySerialNumberQuery, IEnumerable<SolarPanels>>
    {
        public Task<Result<IEnumerable<SolarPanels>>> Handle(GetBySerialNumberQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
