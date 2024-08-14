using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimes {
    [JsonProperty ("crimes")]
    public Dictionary<string, FactionCrime> Crimes { get; set; }
}
