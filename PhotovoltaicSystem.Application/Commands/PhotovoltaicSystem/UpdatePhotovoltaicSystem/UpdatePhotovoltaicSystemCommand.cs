using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Domain.Entities;

namespace PhotovoltaicSystem.Application.Commands
{
    public sealed record UpdatePhotovoltaicSystemCommand(
          PhotovoltaicSystemInstall Photovoltaic
        ) : ICommand;

}

