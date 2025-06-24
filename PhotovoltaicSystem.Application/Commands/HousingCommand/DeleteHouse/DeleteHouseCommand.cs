using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.ValueObjects;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.DeleteHouse
{
    public sealed record DeleteHouseCommand(Address Address, int HouseNumber) : ICommand;
}
