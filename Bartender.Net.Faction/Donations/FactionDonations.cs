using Bartender.Net.Framework.Faction.Donations;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class FactionDonations : IFactionDonations {
    [JsonProperty ("donations")]
    public IDictionary<string, IDonationEntry> Donations { get; set; }
}