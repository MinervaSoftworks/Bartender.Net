using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("applications")]
    public required Dictionary<string, CompanyApplication> Applications { get; set; }
}
