using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Upgrades;

public interface IState {
    [JsonProperty ("peace")]
    Dictionary<string, IUpgrade> Peace { get; }

    [JsonProperty ("state")]
    string StateName { get; }

    [JsonProperty ("upgrades")]
    Dictionary<string, IUpgrade> Upgrades { get; }

    [JsonProperty ("war")]
    Dictionary<string, IUpgrade> War { get; }
}
