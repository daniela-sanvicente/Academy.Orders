using Academy.Orders.Application.Orders.Query.ConfirmOrder;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Academy.Orders.Presentation.Modules;

public static class OrderModules
{

    private const string BASE_URL = "api/v1/orders/";
    public static void AddOrderModules(this IEndpointRouteBuilder app)
    {
        var customerGroup = app.MapGroup(BASE_URL);

        customerGroup.MapPost("", ConfirmOrder);
    }

    private static async Task<IResult> ConfirmOrder(
        [FromBody] ConfirmOrderQueryRequest request,
        ISender sender
        )
    {
        var command = new ConfirmOrderQuery(request);
        var result = await sender.Send(command);

        if (result.Value == null)
            return Results.Content("Unable to confirm order");

        return Results.Created($"{BASE_URL}{result.Value.orderId}", result.Value);
    }
}