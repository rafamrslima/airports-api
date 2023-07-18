using System.Net;
using airports.API.Application.DTOs;
using airports.API.Core.Interfaces;
using Newtonsoft.Json;

namespace airports.API.Repositories;

public class AirportRepository : IAirportRepository
{
    private readonly HttpClient _httpClient;

    public AirportRepository(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<AirportDTO> GetAirportData(string airportCode)
    {
        try 
        {        
            var response = await _httpClient.GetAsync($"{_httpClient.BaseAddress}{airportCode}");
            
            if (response.StatusCode == HttpStatusCode.NotFound) 
                throw new KeyNotFoundException($"Airport code '{airportCode}' not found.");
             
             response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<AirportDTO>(content);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message, ex);
        }
    }
}
