using Academy.Orders.Domain.Shared;
using MediatR;

namespace Academy.Orders.Application.Abstrasctions.Messaging
{
    public interface IQueryHandler<in TQuery, TResponse> : IQueryHandler<TQuery,Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}
