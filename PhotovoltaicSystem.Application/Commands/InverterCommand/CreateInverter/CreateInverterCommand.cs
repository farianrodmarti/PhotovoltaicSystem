using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotovoltaicSystem.Application.Common;


namespace PhotovoltaicSystem.Application.Commands.InverterCommand.CreateInverter
{
    public sealed record CreateInverterCommand(
        string SerialNumber,
        string Model,
        double MaximumPower): ICommand;
}
