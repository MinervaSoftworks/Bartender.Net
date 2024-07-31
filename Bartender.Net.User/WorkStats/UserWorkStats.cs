using Bartender.Net.Framework.User.WorkStats;
using Newtonsoft.Json;

namespace Bartender.Net.User.Work;

public class UserWorkStats : IUserWorkStats {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("manual_labor")]
    public int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public int Endurance { get; set; }
}
