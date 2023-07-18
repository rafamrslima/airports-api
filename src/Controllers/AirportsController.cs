using airports.API.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace airports.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AirportsController : ControllerBase
{
    private readonly IAirportService _airportService;
    public AirportsController(IAirportService airportService)
    {
        _airportService = airportService;
    }

    [HttpGet("distance")]
    public async Task<IActionResult> GetDistance([FromQuery]string from, string to) 
    {
        var distanceInMiles = 
            await _airportService.GetDistanceBetweenAirports(from, to);
        
        return Ok(distanceInMiles);
    }
}