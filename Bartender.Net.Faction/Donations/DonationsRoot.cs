using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class DonationsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("donations")]
    public required Dictionary<string, DonationEntry> Donations { get; set; }
}