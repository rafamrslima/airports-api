using airports.API.Services;
using airports.API.Core.Models;

namespace airports.Tests;

public class DistanceCalculatorTests
{
    [Fact]
    public void Calculate_DistanceBetweenSameLocations_ReturnsZero()
    {
        // Arrange
        var origin = new Location(40.7128, -74.0060);
        var destination = new Location(40.7128, -74.0060);

        // Act
        double distance = DistanceCalculator.Calculate(origin, destination);

        // Assert
        Assert.Equal(0, distance);
    }

    [Fact]
    public void Calculate_DistanceBetweenDifferentLocations_ReturnsCorrectDistance()
    {
        // Arrange
        var origin = new Location(-46.481926, -23.425668);
        var destination = new Location(4.763385, 52.309069);

        // Act
        double distance = DistanceCalculator.Calculate(origin, destination);

        // Assert
        Assert.Equal(6073.9, distance, 1);
    }
}
