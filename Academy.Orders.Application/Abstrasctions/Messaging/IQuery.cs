

using Academy.Orders.Domain.Shared;
using MediatR;

namespace Academy.Orders.Application.Abstrasctions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
