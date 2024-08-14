using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttack {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("code")]
    public string Code { get; set; }

    [JsonProperty ("timestamp_started")]
    public long TimestampStarted { get; set; }

    [JsonProperty ("timestamp_ended")]
    public long TimestampEnded { get; set; }

    [JsonProperty ("attacker_id")]
    public int AttackerId { get; set; }

    [JsonProperty ("attacker_name")]
    public string AttackerName { get; set; }

    [JsonProperty ("attacker_faction")]
    public int AttackerFaction { get; set; }

    [JsonProperty ("attacker_factionname")]
    public string AttackerFactionName { get; set; }

    [JsonProperty ("defender_id")]
    public int DefenderId { get; set; }

    [JsonProperty ("defender_name")]
    public string DefenderName { get; set; }

    [JsonProperty ("defender_faction")]
    public int DefenderFaction { get; set; }

    [JsonProperty ("defender_factionname")]
    public string DefenderFactionName { get; set; }

    [JsonProperty ("result")]
    public string Result { get; set; }

    [JsonProperty ("stealthed")]
    public int Stealthed { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("chain")]
    public int Chain { get; set; }

    [JsonProperty ("raid")]
    public int Raid { get; set; }

    [JsonProperty ("ranked_war")]
    public int RankedWar { get; set; }

    [JsonProperty ("respect_gain")]
    public double RespectGain { get; set; }

    [JsonProperty ("respect_loss")]
    public double RespectLoss { get; set; }

    [JsonProperty ("modifiers")]
    public FactionAttackModifiers Modifiers { get; set; }
}

