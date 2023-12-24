using Newtonsoft.Json;
using TornApi.Net.Models.Common;

namespace TornApi.Net.Models.Faction;

public class Crime {
    public int FactionID { get; set; }

    [JsonProperty ("crime_id")]
    public int ID { get; set; }

    [JsonProperty ("crime_name")]
    public string Name { get; set; }

    [JsonProperty ("initiated")]
    public bool Initiated { get; set; }

    [JsonProperty ("initiated_by")]
    public int InitiatedBy { get; set; }

    [JsonProperty ("money_gain")]
    public int MoneyGain { get; set; }

    [JsonProperty ("participants")]
    public IEnumerable<Status> Members { get; set; }

    [JsonProperty ("planned_by")]
    public int PlannedBy { get; set; }

    [JsonProperty ("respect_gain")]
    public int RespectGain { get; set; }

    [JsonProperty ("success")]
    public bool Success { get; set; }

    [JsonProperty ("time_completed")]
    public long TimeComplete { get; set; }

    [JsonProperty ("time_left")]
    public int TimeLeft { get; set; }

    [JsonProperty ("time_ready")]
    public long TimeReady { get; set; }

    [JsonProperty ("time_created")]
    public long TimeCreated { get; set; }
}
