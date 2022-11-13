using SimpleAPI.Controllers;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void Test1()
    {
        var returnValue = controller.GetWeatherById("Bracing");
        Assert.Equal("Bracing", returnValue.Summary);
    }
}