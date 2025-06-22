

using PhotovoltaicSystem.Application.Common;

namespace PhotovoltaicSystem.Application.Commands.InverterCommand.DeleteInverter
{
    public sealed record DeleteInverterCommand(string SerialNumber): ICommand;
   
}
