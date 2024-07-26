using Bartender.Net.Framework.Company.Applications;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplications : ICompanyApplications {
    [JsonProperty ("applications")]
    public required IDictionary<string, IApplication> Applications { get; set; }
}
