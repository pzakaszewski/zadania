using Moq;
using Xunit;

public interface IWebService
{
    void SendData(string data);
}

public class Calculator
{
    private IWebService _webService;

    public Calculator(IWebService webService)
    {
        _webService = webService;
    }

    public int Add(int a, int b)
    {
        int result = a + b;
        _webService.SendData($"Add operation: {a} + {b} = {result}");
        return result;
    }
}

public class CalculatorTests
{
    [Fact]
    public void Add_ShouldSendDataToWebService()
    {
        Mock<IWebService> webServiceMock = new Mock<IWebService>();
        Calculator calculator = new Calculator(webServiceMock.Object);

        int result = calculator.Add(3, 5);

        Assert.Equal(8, result);

        webServiceMock.Verify(ws => ws.SendData("Add operation: 3 + 5 = 8"), Times.Once);
    }
}
