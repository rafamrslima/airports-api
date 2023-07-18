using airports.API.Core.Models;
using Geolocation;

namespace airports.API.Services;

public static class DistanceCalculator
{
    public static double Calculate(Location origin, Location destination)
    {
        var from = new Coordinate(origin.Latitude, origin.Longitude);
        var to = new Coordinate(destination.Latitude, destination.Longitude);
        return GeoCalculator.GetDistance(from, to);
    }
}
