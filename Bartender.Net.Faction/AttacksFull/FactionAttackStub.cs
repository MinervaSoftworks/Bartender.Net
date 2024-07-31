using Bartender.Net.Framework.Faction.AttacksFull;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttackStub : IFactionAttackStub {
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

    [JsonProperty ("attacker_faction")]
    public int AttackerFaction { get; set; }

    [JsonProperty ("defender_id")]
    public int DefenderId { get; set; }

    [JsonProperty ("defender_faction")]
    public int DefenderFaction { get; set; }

    [JsonProperty ("result")]
    public string Result { get; set; }

    [JsonProperty ("stealthed")]
    public int Stealthed { get; set; }

    [JsonProperty ("respect")]
    public int Respect { get; set; }
}
