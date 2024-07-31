using Bartender.Net.Extensions;
using Bartender.Net.Extensions.User;
using Bartender.Net.Framework.Common.Revives;
using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class Revive : IRevive {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("result")]
    public string Result { get; set; }

    [JsonIgnore]
    public ReviveResult ReviveResult {
        get => Result.ToReviveResult ();
        set => Result = value.ToReviveResultString ();
    }

    [JsonProperty ("chance")]
    public double Chance { get; set; }

    [JsonProperty ("reviver_id")]
    public int ReviverId { get; set; }

    [JsonProperty ("reviver_name")]
    public string ReviverName { get; set; }

    [JsonProperty ("reviver_faction")]
    public int ReviverFaction { get; set; }

    [JsonProperty ("reviver_factionname")]
    public string ReviverFactionname { get; set; }

    [JsonProperty ("target_id")]
    public int TargetId { get; set; }

    [JsonProperty ("target_name")]
    public string TargetName { get; set; }

    [JsonProperty ("target_faction")]
    public int TargetFaction { get; set; }

    [JsonProperty ("target_factionname")]
    public string TargetFactionname { get; set; }

    [JsonProperty ("target_hospital_reason")]
    public string TargetHospitalReason { get; set; }

    [JsonProperty ("target_early_discharge")]
    public int TargetEarlyDischarge { get; set; }

    [JsonProperty ("target_last_action")]
    public ILastAction TargetLastAction { get; set; }
}
