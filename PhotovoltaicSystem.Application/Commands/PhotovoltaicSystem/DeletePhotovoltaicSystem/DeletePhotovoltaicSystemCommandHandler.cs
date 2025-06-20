using FluentResults;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;

namespace PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.DeletePhotovoltaicSystem
{
    public sealed class DeletePhotovoltaicSystemCommandHandler : ICommandHandler<DeletePhotovoltaicSystemCommand>
    {
        private readonly IAppRepositoryManager _repository;

        public async Task<Result> Handle(DeletePhotovoltaicSystemCommand request, CancellationToken cancellationToken)
        {
            _repository.PhotovoltaicSystemInstall.DeleteAsync(request.Id);

            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }
}
