﻿using FluentResults;
using MediatR;

namespace PhotovoltaicSystem.Application.Common
{
    public interface ICommand
        : IRequest<Result>
    {

    }

    public interface ICommand<T>
        : IRequest<Result<T>>
    {

    }
}
