using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Upgrades;

public interface IState {
    [JsonProperty ("peace")]
    Dictionary<string, IUpgrade> Peace { get; set; }

    [JsonProperty ("state")]
    string StateName { get; set; }

    [JsonProperty ("upgrades")]
    Dictionary<string, IUpgrade> Upgrades { get; set; }

    [JsonProperty ("war")]
    Dictionary<string, IUpgrade> War { get; set; }
}
