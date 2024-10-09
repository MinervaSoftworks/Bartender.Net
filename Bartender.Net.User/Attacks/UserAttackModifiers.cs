using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Attacks;

public class UserAttackModifiers : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("fair_fight")]
    public required double FairFight { get; set; }

    [JsonProperty ("war")]
    public required int War { get; set; }

    [JsonProperty ("retaliation")]
    public required int Retaliation { get; set; }

    [JsonProperty ("group_attack")]
    public required int GroupAttack { get; set; }

    [JsonProperty ("overseas")]
    public required int Overseas { get; set; }

    [JsonProperty ("chain_bonus")]
    public required double ChainBonus { get; set; }
}