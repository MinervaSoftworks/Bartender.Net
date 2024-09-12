using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.WorkStats;

public class WorkStatsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("manual_labor")]
    public required int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public required int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public required int Endurance { get; set; }
}
