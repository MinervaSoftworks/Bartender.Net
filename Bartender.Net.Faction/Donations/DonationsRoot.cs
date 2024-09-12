using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class DonationsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("donations")]
    public required Dictionary<string, DonationEntry> Donations { get; set; }
}