using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhotovoltaicSystem.Application.Commands.HousingCommand.CreateHousing
{
    public sealed record CreateHousingCommand(
        int HouseNumber,
        Address Address): ICommand
    {
    }
}
