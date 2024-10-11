using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyProfileRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("company")]
    public virtual required CompanyProfile CompanyProfile { get; set; }
}
