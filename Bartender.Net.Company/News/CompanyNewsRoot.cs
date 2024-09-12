using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNewsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("news")]
    public required Dictionary<string, CompanyNewsEntry> MyProperty { get; set; }
}
