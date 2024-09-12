using Newtonsoft.Json;

namespace Bartender.Net.Company.Companies;

public class CompaniesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cards")]
    public required Dictionary<string, CompanyEntry> Companies { get; set; }
}
