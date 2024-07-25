using Bartender.Net.Framework.User.WorkStats;
using Newtonsoft.Json;

namespace Bartender.Net.User.Work;

public class UserWorkStats : IUserWorkStats {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("manual_labor")]
    public required int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public required int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public required int Endurance { get; set; }
}
