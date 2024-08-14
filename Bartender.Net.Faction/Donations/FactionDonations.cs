using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class FactionDonations {
    [JsonProperty ("donations")]
    public Dictionary<string, DonationEntry> Donations { get; set; }
}