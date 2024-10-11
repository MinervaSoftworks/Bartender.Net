using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttackModifiers : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("fair_fight")]
    public required double FairFight { get; set; }

    [JsonProperty ("war")]
    public required double War { get; set; }

    [JsonProperty ("retaliation")]
    public required double Retaliation { get; set; }

    [JsonProperty ("group_attack")]
    public required double GroupAttack { get; set; }

    [JsonProperty ("overseas")]
    public required double Overseas { get; set; }

    [JsonProperty ("chain_bonus")]
    public required double ChainBonus { get; set; }
}
