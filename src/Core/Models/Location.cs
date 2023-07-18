﻿namespace airports.API.Core.Models;

public class Location
{
    public Location(double longitude, double latitude)
    {
        Longitude = longitude;
        Latitude = latitude;
    }

    public double Longitude { get; set; }
    public double Latitude { get; set; }
}
