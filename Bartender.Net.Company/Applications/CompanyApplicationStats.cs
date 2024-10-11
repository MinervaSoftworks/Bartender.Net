using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationStats : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("endurance")]
    public required float Endurance { get; set; }

    [JsonProperty ("intelligence")]
    public required float Intelligence { get; set; }

    [JsonProperty ("manual_labor")]
    public required float ManualLabor { get; set; }
}
