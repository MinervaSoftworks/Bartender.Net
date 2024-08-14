using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class ApplicationStats {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("endurance")]
    public float Endurance { get; set; }

    [JsonProperty ("intelligence")]
    public float Intelligence { get; set; }

    [JsonProperty ("manual_labor")]
    public float ManualLabor { get; set; }
}
