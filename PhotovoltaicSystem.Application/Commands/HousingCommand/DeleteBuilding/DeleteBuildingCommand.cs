using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.ValueObjects;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.DeleteBuilding
{
    public sealed record DeleteBuildingCommand(Address Address, int HouseNumber) : ICommand;
}
