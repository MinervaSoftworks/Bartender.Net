using Bartender.Net.Faction.Territory;
using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.Territory;

public class Racket : IRacket {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("changed")]
    public int Changed { get; set; }

    [JsonProperty ("created")]
    public int Created { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("reward")]
    public string Reward { get; set; }
}
