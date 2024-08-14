using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class Company {
    [JsonProperty ("company")]
    public CompanyProfile CompanyProfile { get; set; }
}
