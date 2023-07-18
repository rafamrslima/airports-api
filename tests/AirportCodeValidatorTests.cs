using airports.API.Application.Validators;

namespace airports.Tests;

public class AirportCodeValidatorTests
{
    [Fact]
    public void Validate_ValidAirportCode_DoesNotThrowException()
    {
        // Arrange
        string airportCode = "AMS";

        //Act
        var exception = Record.Exception(() => AirportCodeValidator.Validate(airportCode));

        //Assert
        Assert.Null(exception);
    }

    [Fact]
    public void Validate_AirportCodeWithNonLetterCharacters_ThrowsArgumentException()
    {
        // Arrange
        string airportCode = "AB1";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AirportCodeValidator.Validate(airportCode));
    }

    [Fact]
    public void Validate_AirportCodeWithLessThanThreeCharacters_ThrowsArgumentException()
    {
        // Arrange
        string airportCode = "AB";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AirportCodeValidator.Validate(airportCode));
    }

    [Fact]
    public void Validate_AirportCodeWithMoreThanThreeCharacters_ThrowsArgumentException()
    {
        // Arrange
        string airportCode = "ABCD";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => AirportCodeValidator.Validate(airportCode));
    }
}