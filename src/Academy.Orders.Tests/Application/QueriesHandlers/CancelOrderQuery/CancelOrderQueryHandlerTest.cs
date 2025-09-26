using Xunit;

namespace Academy.Orders.Tests.Application.QueriesHandlers.CancelOrderQuery;
public class CancelOrderQueryHandlerTest
{
    // Prueba unitaria para verificar el Happy Path, o la respuesta esperada
	[Fact]
	public async Task Handle_Should_Return_Order_Updated_Data()
    {
        // Arrange (organizar y preparar las pruebas)
        int orderId = 1;

        // Act (Actuar)
        var result = handler.Handle(orderId);   // este handler se tiene que modificar para poder hacer 
        //var result = handler.Handle(orderId);       // ejemplo con un objeto, para poder correr la prueba

        // Assert (verificar)
        Assert.NotNull(result);

    }

    // Prueba unitaria para verificar un error test con OrderID es nulo
    [Theory]
    [InLineData(null)]

    public async Task Handle_Should_Return_Error_When_OrderId_Is_Null(int? orderId)
    {
        // Arrange (organizar y preparar las pruebas)
        int? order = orderId;

        // Act (Actuar)
        var result = order;

        // Assert (verificar)
        Assert.Null(result);
    }

    // Prueba unitaria para verificar un error test cuando OrderID no existe en la base de datos
    [Fact]
    public async Task Handle_Should_Return_Error_When_OrderId_Is_Not_In_Database()
    {
        // Arrange (organizar y preparar las pruebas)

        // Act (Actuar)

        // Assert (verificar)
    }

    // Prueba unitaria para verificar un error test cuando el estado de la OrderID es diferente de "Pendiente" o "Creada"
    [Fact]
    public async Task Handle_Should_Return_Error_When_Status_Of_OrderId_Is_Not_Pending_Or_Not_Created()
    {
        // Arrange (organizar y preparar las pruebas)

        // Act (Actuar)

        // Assert (verificar)
    }
}
