using Bartender.Net.Framework.Company.Applications;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Applications;

public class CompanyApplications : ICompanyApplications {
    [JsonProperty ("applications")]
    public IDictionary<string, IApplication> Applications { get; set; }
}
