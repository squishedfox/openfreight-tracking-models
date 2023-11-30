namespace OpenFreight.Tracking.Models;

public class Location
{
    public string? AddressLine1 { get; set; }
    public string? AddressLine2 { get; set; }
    public string? AddressLine3 { get; set; }
    public required string City { get; set; }
    public string? StateOrProvince { get; set; }
    public required string PostalOrZipCode { get; set; }
    public required string CountryCode { get; set; }
    public required decimal Latitude { get; set; }
    public required decimal Longitude { get; set; }
}