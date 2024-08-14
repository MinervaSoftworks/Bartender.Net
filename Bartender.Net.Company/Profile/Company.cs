using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class Company {
    [JsonProperty ("company")]
    public required CompanyProfile CompanyProfile { get; set; }
}
