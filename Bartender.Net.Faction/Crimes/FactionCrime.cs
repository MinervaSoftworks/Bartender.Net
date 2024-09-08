using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrime {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("crime_id")]
    public required int CrimeType { get; set; }

    [JsonProperty ("crime_name")]
    public required string Name { get; set; }

    [JsonProperty ("initiated")]
    public required bool Initiated { get; set; }

    [JsonProperty ("initiated_by")]
    public required int InitiatedBy { get; set; }

    [JsonProperty ("money_gain")]
    public required int MoneyGain { get; set; }

    [JsonProperty ("participants")]
    public required Dictionary<string, Status> Participants { get; set; }

    [JsonProperty ("planned_by")]
    public required int PlannedBy { get; set; }

    [JsonProperty ("respect_gain")]
    public required int RespectGain { get; set; }

    [JsonProperty ("success")]
    public bool Success { get; set; }

    [JsonProperty ("time_completed")]
    public required long TimeComplete { get; set; }

    [JsonProperty ("time_left")]
    public required int TimeLeft { get; set; }

    [JsonProperty ("time_ready")]
    public required long TimeReady { get; set; }

    [JsonProperty ("time_started")]
    public required long TimeStarted { get; set; }
}
