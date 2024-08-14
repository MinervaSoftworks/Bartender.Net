using Newtonsoft.Json;

namespace Bartender.Net.Faction.Chains;

public class ChainStub {
    [JsonProperty ("userID")]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("respect")]
    public required string Respect { get; set; }

    [JsonProperty ("start")]
    public required int Start { get; set; }

    [JsonProperty ("end")]
    public required int End { get; set; }
}
