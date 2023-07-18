namespace airports.API.Application.Validators;

public static class AirportCodeValidator
{
    public static void Validate(string airportCode)
    {
        if (!IsAllLetters(airportCode))
            throw new ArgumentException($"Airport code '{airportCode}' must contain only letters.");

        if (airportCode.Length != 3)
            throw new ArgumentException($"Airport code '{airportCode}' must have exactly 3 characters.");
    }

    private static bool IsAllLetters(string input)
    {
        return input.All(c => char.IsLetter(c));
    }
}
