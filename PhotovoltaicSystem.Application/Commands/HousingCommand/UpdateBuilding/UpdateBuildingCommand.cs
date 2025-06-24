using PhotovoltaicSystem.Domain.Entities;
using PhotovoltaicSystem.Application.Common;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.UpdateBuilding
{
    public sealed record UpdateBuildingCommand(Building Building) : ICommand;
    
}
