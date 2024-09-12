using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("rankedwars")]
    public required Dictionary<string, RankedWarEntry> Wars { get; set; }
}
