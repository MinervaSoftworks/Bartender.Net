using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplications {
    [JsonProperty ("applications")]
    public Dictionary<string, Application> Applications { get; set; }
}
