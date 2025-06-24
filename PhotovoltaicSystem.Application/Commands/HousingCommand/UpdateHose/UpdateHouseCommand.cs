using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.HousingCommand.UpdateHose
{
    public sealed record UpdateHouseCommand(
          House House
        ) : ICommand;
}
