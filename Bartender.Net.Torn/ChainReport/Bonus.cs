using Newtonsoft.Json;
using TornApi.Net.Models.Torn;

namespace Bartender.Net.Torn.ChainReport;

public class Bonus : IChainBonues {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public int Chain { get; set; }

    [JsonProperty ("attacker")]
    public int Attacker { get; set; }

    [JsonProperty ("defender")]
    public int Defender { get; set; }

    [JsonProperty ("respect")]
    public int Respect { get; set; }
}
