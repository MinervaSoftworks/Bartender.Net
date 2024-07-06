using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Modifiers {
    [JsonIgnore]
    public int ID { get; set; }
    
    [JsonProperty("fair_fight")]
    public double? FairFight { get; set; }

    [JsonProperty("war")]
    public int? War { get; set; }

    [JsonProperty("retaliation")]
    public int? Retaliation { get; set; }

    [JsonProperty("group_attack")]
    public int? GroupAttack { get; set; }

    [JsonProperty("overseas")]
    public int? Overseas { get; set; }

    [JsonProperty("chain_bonus")]
    public double? ChainBonus { get; set; }
}