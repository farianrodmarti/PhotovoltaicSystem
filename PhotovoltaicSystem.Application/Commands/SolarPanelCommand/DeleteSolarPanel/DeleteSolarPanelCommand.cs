using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ICommand = PhotovoltaicSystem.Application.Common.ICommand;

namespace PhotovoltaicSystem.Application.Commands.SolarPanelCommand.DeleteSolarPanel
{
    public sealed record DeleteSolarPanelCommand(string SerialNumber) : ICommand;
}
