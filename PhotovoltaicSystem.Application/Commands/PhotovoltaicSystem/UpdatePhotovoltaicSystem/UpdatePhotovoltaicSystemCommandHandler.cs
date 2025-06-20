using FluentResults;
using PhotovoltaicSystem.Application.Commands.PhotovoltaicSystem.CreatePhotovoltaicSystem;
using PhotovoltaicSystem.Application.Common;
using PhotovoltaicSystem.Contracts;
using PhotovoltaicSystem.Contracts.Reposotories.Managers;
using PhotovoltaicSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotovoltaicSystem.Application.Commands
{
    public sealed class UpdatePhotovoltaicSystemCommandHandler : ICommandHandler<UpdatePhotovoltaicSystemCommand>
    {
        private readonly IAppRepositoryManager _repository;
        //private readonly IUnitOfWork _unitOfWork;
        public UpdatePhotovoltaicSystemCommandHandler(IAppRepositoryManager repository)
        {
            _repository = repository;
        }

        public async Task<Result> Handle(UpdatePhotovoltaicSystemCommand request, CancellationToken cancellationToken)
        {
            await _repository.PhotovoltaicSystemInstall.UpdateAsync(request.Photovoltaic);

            await _repository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return Result.Ok();
        }
    }

}