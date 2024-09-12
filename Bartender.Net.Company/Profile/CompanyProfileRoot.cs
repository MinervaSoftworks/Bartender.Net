using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyProfileRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company")]
    public required CompanyProfile CompanyProfile { get; set; }
}
