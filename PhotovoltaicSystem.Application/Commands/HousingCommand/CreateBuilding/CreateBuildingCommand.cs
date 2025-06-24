using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.CreateBuilding
{
    public sealed record CreateBuildingCommand(
        int HouseNumber,
        Address Address,
        int numberOfApartment) : ICommand
    {
    }
}
