using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands.SolarPanelCommand.CreateSolarPanel
{
    public sealed record CreateSolarPanelCommand(
       string SerialNumber,
       string Model,
       Capacity Capacity
        ): ICommand; 
}
