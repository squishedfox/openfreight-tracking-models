namespace OpenFreight.Tracking.Models;

public class Milestone
{
    public required IEnumerable<string> ShipmentIDs { get; set; } = new List<string>();
    public required IEnumerable<string> OrderIDs { get; set; } = new List<string>();
    public required string Description { get; set; }
    public required Location Location { get; set; }
    public required string Status { get; set; }
    public required DateTime Date { get; set; }
    public required string? Notes { get; set; }
    public required IEnumerable<IdentifyingCodes> IdentifyingCodes { get; set; } = new List<IdentifyingCodes>();
    public required IEnumerable<Reference> References { get; set; } = new List<Reference>();
}