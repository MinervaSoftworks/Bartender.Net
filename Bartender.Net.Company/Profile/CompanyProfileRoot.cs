using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyProfileRoot : BartenderEntity {
    [JsonProperty ("company")]
    public virtual required CompanyProfile CompanyProfile { get; set; }
}
