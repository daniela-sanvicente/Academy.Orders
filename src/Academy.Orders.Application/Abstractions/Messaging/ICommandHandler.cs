using Academy.Orders.Domain.Shared;
using MediatR;

namespace Academy.Orders.Application.Abstractions.Messaging;
internal interface ICommandHandler<TCommand, TResponse> : IRequestHandler<TCommand, Result<TResponse>>
    where TCommand : ICommand<TResponse>
{

}