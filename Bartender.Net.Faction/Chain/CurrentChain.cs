using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chain;

public class CurrentChain : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("current")]
    public required int Current { get; set; }

    [JsonProperty ("max")]
    public required int Max { get; set; }

    [JsonProperty ("timeout")]
    public required int Timeout { get; set; }

    [JsonProperty ("modifier")]
    public required int Modifier { get; set; }

    [JsonProperty ("cooldown")]
    public required int Cooldown { get; set; }

    [JsonProperty ("start")]
    public required int Start { get; set; }

    [JsonProperty ("end")]
    public required int End { get; set; }
}
