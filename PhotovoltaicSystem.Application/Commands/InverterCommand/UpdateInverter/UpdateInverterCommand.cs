using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.InverterCommand.UpdateInverter
{
    public sealed record UpdateInverterCommand(Inverter Inverter): ICommand
    {
    }
}
