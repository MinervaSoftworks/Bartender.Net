using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyProfileRoot{
    [JsonProperty ("company")]
    public required CompanyProfile CompanyProfile { get; set; }
}
