using ContinuousDeployment.Controllers;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace ContinuousDeployment.Tests
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void Get_WeatherForecast_ShouldWorkAsExpected()
        {
            // Arrange

            var logger = new Mock<ILogger<WeatherForecastController>>();

            WeatherForecastController controller = new WeatherForecastController(logger.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotEmpty(result);
        }
    }
}
