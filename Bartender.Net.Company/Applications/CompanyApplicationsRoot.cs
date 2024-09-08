using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplicationsRoot {
    [JsonProperty ("applications")]
    public required Dictionary<string, CompanyApplication> Applications { get; set; }
}
