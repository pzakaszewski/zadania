using Moq;
using Xunit;

public interface IOrderService
{
    void PlaceOrder(string product, int quantity);
}

public class OrderProcessor
{
    private IOrderService _orderService;

    public OrderProcessor(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public void ProcessOrder(string product, int quantity)
    {
        _orderService.PlaceOrder(product, quantity);
    }
}


public class OrderProcessorTests
{
    [Fact]
    public void ProcessOrder_ShouldCallPlaceOrderWithCorrectParameters()
    {
        Mock<IOrderService> orderServiceMock = new Mock<IOrderService>();
        OrderProcessor orderProcessor = new OrderProcessor(orderServiceMock.Object);

        orderProcessor.ProcessOrder("ProductABC", 3);

        orderServiceMock.Verify(os => os.PlaceOrder("ProductABC", 3), Times.Once);
    }

    [Fact]
    public void ProcessOrder_ShouldCallPlaceOrderMultipleTimes()
    {
        Mock<IOrderService> orderServiceMock = new Mock<IOrderService>();
        OrderProcessor orderProcessor = new OrderProcessor(orderServiceMock.Object);

        orderProcessor.ProcessOrder("Product1", 2);
        orderProcessor.ProcessOrder("Product2", 5);

        orderServiceMock.Verify(os => os.PlaceOrder("Product1", 2), Times.Once);
        orderServiceMock.Verify(os => os.PlaceOrder("Product2", 5), Times.Once);
    }
}