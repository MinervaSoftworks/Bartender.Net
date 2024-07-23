using Bartender.Net.Framework;
using Bartender.Net.Framework.User.Attacking;
using Newtonsoft.Json;

namespace Bartender.Net.User.Attacking;

public class Attack : IAttack {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("code")]
    public required string Code { get; set; }

    [JsonProperty ("timestamp_started")]
    public required int TimestampStarted { get; set; }

    [JsonProperty ("timestamp_ended")]
    public required int TimestampEnded { get; set; }

    [JsonProperty ("attacker_id")]
    public required int AttackerId { get; set; }

    [JsonProperty ("attacker_name")]
    public required string AttackerName { get; set; }

    [JsonProperty ("attacker_faction")]
    public required int AttackerFaction { get; set; }

    [JsonProperty ("attacker_factionname")]
    public required string AttackerFactionName { get; set; }

    [JsonProperty ("defender_id")]
    public required int DefenderId { get; set; }

    [JsonProperty ("defender_name")]
    public required string DefenderName { get; set; }

    [JsonProperty ("defender_faction")]
    public required int DefenderFaction { get; set; }

    [JsonProperty ("defender_factionname")]
    public required string DefenderFactionname { get; set; }

    [JsonProperty ("result")]
    public required string Result { get; set; }

    [JsonProperty ("stealthed")]
    public required int Stealthed { get; set; }

    [JsonProperty ("respect")]
    public required double Respect { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("raid")]
    public required int Raid { get; set; }

    [JsonProperty ("ranked_war")]
    public required int RankedWar { get; set; }

    [JsonProperty ("respect_gain")]
    public required double RespectGain { get; set; }

    [JsonProperty ("respect_loss")]
    public required double RespectLoss { get; set; }

    [JsonProperty ("modifiers")]
    public required AttackModifiers Modifiers { get; set; }
}
