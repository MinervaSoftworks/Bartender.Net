using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.Extensions;
using Bartender.Net.Framework.Extensions.User;
using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Revives;

public class Revive {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("result")]
    public required string Result { get; set; }

    [JsonIgnore]
    public ReviveResult ReviveResult {
        get => Result.ToReviveResult ();
        set => Result = value.ToReviveResultString ();
    }

    [JsonProperty ("chance")]
    public required double Chance { get; set; }

    [JsonProperty ("reviver_id")]
    public required int ReviverId { get; set; }

    [JsonProperty ("reviver_name")]
    public required string ReviverName { get; set; }

    [JsonProperty ("reviver_faction")]
    public required int ReviverFaction { get; set; }

    [JsonProperty ("reviver_factionname")]
    public required string ReviverFactionname { get; set; }

    [JsonProperty ("target_id")]
    public required int TargetId { get; set; }

    [JsonProperty ("target_name")]
    public required string TargetName { get; set; }

    [JsonProperty ("target_faction")]
    public required int TargetFaction { get; set; }

    [JsonProperty ("target_factionname")]
    public required string TargetFactionname { get; set; }

    [JsonProperty ("target_hospital_reason")]
    public required string TargetHospitalReason { get; set; }

    [JsonProperty ("target_early_discharge")]
    public required int TargetEarlyDischarge { get; set; }

    [JsonProperty ("target_last_action")]
    public required LastAction TargetLastAction { get; set; }
}
