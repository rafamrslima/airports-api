using Newtonsoft.Json;

namespace airports.API.Application.DTOs;

[JsonObject]
public class AirportDTO
{
    [JsonProperty("country")]
    public string Country { get; set; }

    [JsonProperty("iata")]
    public string Iata { get; set; }

    [JsonProperty("location")]
    public Location Location { get; set; }
}

public class Location
{
    [JsonProperty("lon")]
    public double Longitude { get; set; }
    
    [JsonProperty("lat")]
    public double Latitude { get; set; }
}

