using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("applications")]
    public required Dictionary<string, CompanyApplication> Applications { get; set; }
}
