using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimesRoot {
    [JsonProperty ("crimes")]
    public required Dictionary<string, FactionCrime> Crimes { get; set; }
}
