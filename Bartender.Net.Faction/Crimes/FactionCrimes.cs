using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimes {
    [JsonProperty ("crimes")]
    public required Dictionary<string, FactionCrime> Crimes { get; set; }
}
