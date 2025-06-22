using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Application.Common;


namespace PhotovoltaicSystem.Application.Commands.SolarPanelCommand.UpdateSolarPanel
{
    public sealed record UpdateSolarPanelCommand (SolarPanel SolarPanel) : ICommand;
    
}
