using Academy.Orders.Application.Commands.CancelOrder;
using Academy.Orders.Domain.Shared;
using MediatR;

namespace Academy.Orders.Application.Orders.Commands.CancelOrder;
public sealed record CancelOrderCommand(int orderId) : IRequest<Result<CancelOrderCommandResponse>>;