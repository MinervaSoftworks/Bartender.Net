using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("crimes")]
    public required Dictionary<string, FactionCrime> Crimes { get; set; }
}
