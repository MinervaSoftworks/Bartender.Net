using Bartender.Net.Framework.Faction.Crimes;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimes : IFactionCrimes {
    [JsonProperty ("crimes")]
    public IDictionary<string, IFactionCrime> Crimes { get; set; }
}
