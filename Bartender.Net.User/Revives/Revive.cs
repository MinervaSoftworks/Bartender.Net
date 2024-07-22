using Bartender.Net.User.Profile;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Bartender.Net.User.Revives;

public class Revive {
    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("result")]
    public required string Result {
        get => ReviveResultToResult (ReviveResult);
        set => ReviveResult = ResultToReviveResult (value);
    }

    [JsonIgnore]
    public ReviveResult ReviveResult { get; private set; }

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
    
    public static string ReviveResultToResult (ReviveResult result) => result switch {
        ReviveResult.Failure => "failure",
        ReviveResult.Success => "success",
        _ => throw new Exception ("Invalid Revive result")
    };

    public static ReviveResult ResultToReviveResult (string value) => value switch {
        "success" => ReviveResult.Success,
        "failure" => ReviveResult.Failure,
        _ => throw new Exception ("Invalid Revive result")
    };
}
