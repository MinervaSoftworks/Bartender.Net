using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class War : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("end")]
    public required long End { get; set; }

    [JsonProperty ("start")]
    public required long Start { get; set; }

    [JsonProperty ("target")]
    public required int Target { get; set; }

    [JsonProperty ("winner")]
    public required int Winner { get; set; }
}
