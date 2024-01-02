using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class BattleStats {
    public int BattleStatsID { get; set; }

    [JsonProperty ("strength")]
    public int Strength { get; set; }

    [JsonProperty ("speed")]
    public int Speed { get; set; }

    [JsonProperty ("dexterity")]
    public int Dexterity { get; set; }

    [JsonProperty ("defense")]
    public int Defense { get; set; }

    [JsonProperty ("total")]
    public int Total { get; set; }

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
