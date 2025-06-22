using PhotovoltaicSystem.Application.Common;
using SolarPanels = PhotovoltaicSystem.Domain.Entities.SolarPanel;

namespace PhotovoltaicSystem.Application.Queries.SolarPanel.GetBySerialNumber
{
    public sealed record GetBySerialNumberQuery(string SerialNumber) 
        : IQuery<IEnumerable<SolarPanels>>;
}
