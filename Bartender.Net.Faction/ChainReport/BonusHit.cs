using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class BonusHit {
    [JsonProperty ("userID")]
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
