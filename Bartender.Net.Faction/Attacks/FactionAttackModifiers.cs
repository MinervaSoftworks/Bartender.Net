using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttackModifiers : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("fair_fight")]
    public double FairFight { get; set; }

    [JsonProperty ("war")]
    public double War { get; set; }

    [JsonProperty ("retaliation")]
    public double Retaliation { get; set; }

    [JsonProperty ("group_attack")]
    public double GroupAttack { get; set; }

    [JsonProperty ("overseas")]
    public double Overseas { get; set; }

    [JsonProperty ("chain_bonus")]
    public double ChainBonus { get; set; }
}
