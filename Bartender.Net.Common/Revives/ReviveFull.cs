using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class ReviveFull : IReviveFull {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("chance")]
    public double Chance { get; set; }

    [JsonProperty ("result")]
    public string Result { get; set; }

    [JsonProperty ("reviver_faction")]
    public int ReviverFaction { get; set; }

    [JsonProperty ("reviver_id")]
    public int ReviverId { get; set; }

    [JsonProperty ("target_early_discharge")]
    public int TargetEarlyDischarge { get; set; }

    [JsonProperty ("target_faction")]
    public int TargetFaction { get; set; }

    [JsonProperty ("target_hospital_reason")]
    public string TargetHospitalReason { get; set; }

    [JsonProperty ("target_id")]
    public int TargetId { get; set; }

    [JsonProperty ("target_last_action")]
    public ILastAction TargetLastAction { get; set; }

    [JsonProperty ("timestamp")]
    public int TimeStamp { get; set; }
}
