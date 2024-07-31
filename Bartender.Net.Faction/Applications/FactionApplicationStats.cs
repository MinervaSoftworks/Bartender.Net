using Bartender.Net.Framework.Faction.Applications;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplicationStats : IFactionApplicationStats {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("strength")]
    public int Strength { get; set; }

    [JsonProperty ("defense")]
    public int Defense { get; set; }

    [JsonProperty ("speed")]
    public int Speed { get; set; }

    [JsonProperty ("dexterity")]
    public int Dexterity { get; set; }
}
