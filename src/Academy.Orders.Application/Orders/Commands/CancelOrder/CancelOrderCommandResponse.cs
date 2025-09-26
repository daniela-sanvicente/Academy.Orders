namespace Academy.Orders.Application.Orders.Commands.CancelOrder;

public class CancelOrderCommandResponse
{
    public int orderId { get; set; }
    public string? status { get; set; } = string.Empty;
    public DateTime cancellationDate { get; set; }
}