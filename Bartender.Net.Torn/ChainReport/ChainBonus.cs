using Newtonsoft.Json;

namespace Bartender.Net.Torn.ChainReport;

public class ChainBonus {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("attacker")]
    public required int Attacker { get; set; }

    [JsonProperty ("defender")]
    public required int Defender { get; set; }

    [JsonProperty ("respect")]
    public required int Respect { get; set; }
}
