using airports.API.Application.DTOs;

namespace airports.API.Core.Interfaces;

public interface IAirportRepository
{
    Task<AirportDTO> GetAirportData(string airportCode);
}
