using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class WorkingStats {
    [JsonIgnore]
    public int ID { get; set; }

    public int WorkinStatsID { get; set; }

    [JsonProperty ("manual_labor")]
    public long ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public long Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public long Endurance { get; set; }
}
