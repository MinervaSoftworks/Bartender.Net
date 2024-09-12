using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("crimes")]
    public required Dictionary<string, FactionCrime> Crimes { get; set; }
}
