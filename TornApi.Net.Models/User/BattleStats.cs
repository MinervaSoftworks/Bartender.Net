using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class BattleStats {
    [JsonIgnore]
    public int ID { get; set; }

    public int BattleStatsID { get; set; }

    [JsonProperty ("strength")]
    public long Strength { get; set; }

    [JsonProperty ("speed")]
    public long Speed { get; set; }

    [JsonProperty ("dexterity")]
    public long Dexterity { get; set; }

    [JsonProperty ("defense")]
    public long Defense { get; set; }

    [JsonProperty ("total")]
    public long Total { get; set; }

    [JsonProperty ("strength_modifier")]
    public int StrengthModifier { get; set; }

    [JsonProperty ("defense_modifier")]
    public int DefenseModifier { get; set; }

    [JsonProperty ("speed_modifier")]
    public int SpeedModifier { get; set; }

    [JsonProperty ("dexterity_modifier")]
    public int DexterityModifier { get; set; }

    [JsonProperty ("strength_info")]
    public IEnumerable<string> StrengthInfo { get; set; }

    [JsonProperty ("defense_info")]
    public IEnumerable<string> DefenseInfo { get; set; }

    [JsonProperty ("speed_info")]
    public IEnumerable<string> SpeedInfo { get; set; }

    [JsonProperty ("dexterity_info")]
    public IEnumerable<string> DexterityInfo { get; set; }
}
