namespace airports.API.Core.Interfaces;

public interface IAirportService
{
    Task<double> GetDistanceBetweenAirports(string airportCodeFrom, string airportCodeTo);
}
