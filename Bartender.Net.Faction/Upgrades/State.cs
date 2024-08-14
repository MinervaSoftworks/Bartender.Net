using Newtonsoft.Json;

namespace Bartender.Net.Faction.Upgrades;

public class State {
    [JsonProperty ("peace")]
    public Dictionary<string, Upgrade> Peace { get; set; }

    [JsonProperty ("state")]
    public string StateName { get; set; }

    [JsonProperty ("upgrades")]
    public Dictionary<string, Upgrade> Upgrades { get; set; }

    [JsonProperty ("war")]
    public Dictionary<string, Upgrade> War { get; set; }
}
