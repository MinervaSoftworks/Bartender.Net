using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("rankedwars")]
    public required Dictionary<string, RankedWarEntry> Wars { get; set; }
}
