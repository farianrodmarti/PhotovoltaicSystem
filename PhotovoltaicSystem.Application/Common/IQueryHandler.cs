using FluentResults;
using MediatR;

namespace PhotovoltaicSystem.Application.Common
{
    public interface IQueryHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, Result<TResponse>>
        where TRequest : IQuery<TResponse>
    {

    }
}
