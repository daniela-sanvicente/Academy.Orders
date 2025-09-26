using Academy.Orders.Application.Commands.CancelOrder;
using Academy.Orders.Application.Orders.Commands.CancelOrder;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace Academy.Orders.Presentation.Modules;
public static class OrderModules
{
    private const string BASE_URL = "api/v1/order/";
    public static void AddOrderModules(this IEndpointRouteBuilder app)
    {
        var orderGroup = app.MapGroup(BASE_URL);

        //orderGroup.MapPost("", CreateOrder);
        orderGroup.MapPut("{orderId}/cancel", CancelOrder);
        //orderGroup.MapPut($"{id}", CancelOrder);
        //orderGroup.MapPut("", CancelOrder).RequireAuthorization();       // en esta parte necesita una autorización de un token porque es una api protegida
    }

    private static async Task<IResult> CancelOrder(
        [FromRoute] int orderId,
        ISender sender,     //interfaz que ayuda a mandar a llamar el handler
        CancellationToken cancellationToken)    //se utiliza cuando falla la petición
    {
        CancelOrderCommand command = new CancelOrderCommand(orderId);
        var result = await sender.Send(command, cancellationToken);

        //esta parte la cambié por la de abajo
        /* if (result.Value == null)
            return Results.Content("Unable to cancel order");

        return Results.Created($"{BASE_URL}{result.Value.orderId}", result.Value); */

        if (!result.IsSuccess)
        {
            return Results.NotFound(result.Error);
        }

        return Results.Ok(result.Value);
    }
}
