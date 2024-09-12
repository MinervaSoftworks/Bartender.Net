using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Attacks;

public class UserAttack : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("code")]
    public required string Code { get; set; }

    [JsonProperty ("timestamp_started")]
    public required int TimestampStarted { get; set; }

    [JsonProperty ("timestamp_ended")]
    public required int TimestampEnded { get; set; }

    [JsonProperty ("attacker_id")]
    public required string AttackerId { get; set; }

    [JsonProperty ("attacker_name")]
    public required string AttackerName { get; set; }

    [JsonProperty ("attacker_faction")]
    public required string AttackerFaction { get; set; }

    [JsonProperty ("attacker_factionname")]
    public required string AttackerFactionName { get; set; }

    [JsonProperty ("defender_id")]
    public required string DefenderId { get; set; }

    [JsonProperty ("defender_name")]
    public required string DefenderName { get; set; }

    [JsonProperty ("defender_faction")]
    public required string DefenderFaction { get; set; }

    [JsonProperty ("defender_factionname")]
    public required string DefenderFactionname { get; set; }

    [JsonProperty ("result")]
    // TODO Enum
    public required string Result { get; set; }

    [JsonProperty ("stealthed")]
    public required bool Stealthed { get; set; }

    [JsonProperty ("respect")]
    public required double Respect { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("raid")]
    public required bool Raid { get; set; }

    [JsonProperty ("ranked_war")]
    public required bool RankedWar { get; set; }

    [JsonProperty ("respect_gain")]
    public required double RespectGain { get; set; }

    [JsonProperty ("respect_loss")]
    public required double RespectLoss { get; set; }

    [JsonProperty ("modifiers")]
    public required UserAttackModifiers Modifiers { get; set; }
}
