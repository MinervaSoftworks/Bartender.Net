using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class DonationsRoot {
    [JsonProperty ("donations")]
    public required Dictionary<string, DonationEntry> Donations { get; set; }
}