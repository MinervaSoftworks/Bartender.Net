using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplicationStats {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }
}
