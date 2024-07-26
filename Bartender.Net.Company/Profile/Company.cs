using Bartender.Net.Framework.Company.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class Company : ICompany {
    [JsonProperty ("company")]
    public required ICompanyProfile CompanyProfile { get; set; }
}
