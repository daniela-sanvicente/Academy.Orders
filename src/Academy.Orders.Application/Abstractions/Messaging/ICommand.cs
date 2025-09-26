using Academy.Orders.Domain.Shared;
using MediatR;

namespace Academy.Orders.Application.Abstractions.Messaging;

public interface ICommand<TResponse> : IRequest<Result<TResponse>>;