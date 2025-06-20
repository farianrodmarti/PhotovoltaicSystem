using ICommand = PhotovoltaicSystem.Application.Common.ICommand;

namespace PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.DeletePhotovoltaicSystem
{
    public sealed record DeletePhotovoltaicSystemCommand(Guid Id) : ICommand;
}
