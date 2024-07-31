using Bartender.Net.Framework.Faction.Upgrades;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Upgrades;

public class State : IState {
    [JsonProperty ("peace")]
    public Dictionary<string, IUpgrade> Peace { get; set; }

    [JsonProperty ("state")]
    public string StateName { get; set; }

    [JsonProperty ("upgrades")]
    public Dictionary<string, IUpgrade> Upgrades { get; set; }

    [JsonProperty ("war")]
    public Dictionary<string, IUpgrade> War { get; set; }
}
