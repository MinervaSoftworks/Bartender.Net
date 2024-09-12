using Newtonsoft.Json;

namespace Bartender.Net.Faction.Upgrades;

public class UpgradesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("peace")]
    public required Dictionary<string, Upgrade> Peace { get; set; }

    [JsonProperty ("state")]
    public required string StateName { get; set; }

    [JsonProperty ("upgrades")]
    public required Dictionary<string, Upgrade> Upgrades { get; set; }

    [JsonProperty ("war")]
    public required Dictionary<string, Upgrade> War { get; set; }
}
