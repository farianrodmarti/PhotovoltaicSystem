using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.Entities;

namespace PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.CreatePhotovoltaicSystem
{
    public sealed record CreatePhotovoltaicSystemCommand(
        bool HasBattery,
        Inverter Inverter,
        List<SolarPanel> SolarPanels) : ICommand;

}
