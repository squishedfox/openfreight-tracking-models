namespace OpenFreight.Tracking.Models;

public class Shipment
{
    public required string ShipmentID { get; set; }
    public required IEnumerable<string> OrderIDs { get; set; } = new List<string>();
    public required IEnumerable<Reference> References { get; set; } = new List<Reference>();
}