using airports.API.Core.Models;
using airports.API.Core.Interfaces;
using airports.API.Application.Validators;

namespace airports.API.Services;

public class AirportService : IAirportService
{
    private readonly IAirportRepository _airportRepository;
    public AirportService(IAirportRepository airportRepository)
    {
        _airportRepository = airportRepository;
    }
     public async Task<double> GetDistanceBetweenAirports(string airportCodeFrom, string airportCodeTo)
    {
        AirportCodeValidator.Validate(airportCodeFrom);
        AirportCodeValidator.Validate(airportCodeTo);
        
        var airportFrom = await _airportRepository.GetAirportData(airportCodeFrom.ToUpper());
        var airportTo = await _airportRepository.GetAirportData(airportCodeTo.ToUpper());

        var origin = new Location(airportFrom.Location.Longitude, airportFrom.Location.Latitude);
        var destination = new Location(airportTo.Location.Longitude, airportTo.Location.Latitude);

        return DistanceCalculator.Calculate(origin, destination); 
    }
}
