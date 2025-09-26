using Academy.Orders.Domain.Shared;
using MediatR;

namespace Academy.Orders.Application.Orders.Commands.CancelOrder;
public class CancelOrderComandHandler : IRequestHandler<CancelOrderCommand, Result<CancelOrderCommandResponse>>
{
    public Task<Result<CancelOrderCommandResponse>> Handle(CancelOrderCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
