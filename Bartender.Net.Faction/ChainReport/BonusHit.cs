using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class BonusHit : IBartenderEntity {
    [JsonProperty ("userID")]
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
