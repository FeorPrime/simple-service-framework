//#Date: 2024-2-12
//#Author: Generated by GoCodeo.

using Xunit;
using System;

using simple_framework_app.Controllers;
using simple_framework_app;

public class WeatherForecastControllerTests
{
    [Fact]
    public void TestGetWeatherForecast_SuccessfulResponse()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<List<WeatherForecast>>(result);
        Assert.NotEmpty(result);
    }

    [Fact]
    public void Get_ReturnsEmptyWeatherForecast()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void Get_ReturnsWeatherForecastWithNegativeTemperature()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        foreach (var forecast in result)
        {
            Assert.True(forecast.TemperatureC < 0);
        }
    }

    [Fact]
    public void Get_ReturnsValidTemperature()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        foreach (var forecast in result)
        {
            Assert.InRange(forecast.TemperatureC, -20, 55);
        }
    }

    [Fact]
    public void Get_ReturnsWeatherForecasts_WithEmptySummary()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        foreach (var forecast in result)
        {
            Assert.Equal(string.Empty, forecast.Summary);
        }
    }

    [Fact]
    public void Get_InvalidDate_ReturnsEmptyArray()
    {
        // Arrange
        var controller = new WeatherForecastController(null);

        // Act
        var result = controller.Get();

        // Assert
        Assert.Empty(result);
    }
} 

