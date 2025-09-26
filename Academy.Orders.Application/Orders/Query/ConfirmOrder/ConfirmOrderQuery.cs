using MediatR;
using Academy.Orders.Domain.Shared;

namespace Academy.Orders.Application.Orders.Query.ConfirmOrder;

public sealed record ConfirmOrderQuery(ConfirmOrderQueryRequest request) : IRequest<Result<ConfirmOrderQueryResponse>>;
