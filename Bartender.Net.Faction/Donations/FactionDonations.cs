using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class FactionDonations {
    [JsonProperty ("donations")]
    public required Dictionary<string, DonationEntry> Donations { get; set; }
}