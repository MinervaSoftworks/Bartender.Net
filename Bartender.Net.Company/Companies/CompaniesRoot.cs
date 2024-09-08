using Newtonsoft.Json;

namespace Bartender.Net.Company.Companies;

public class CompaniesRoot {
    [JsonProperty ("cards")]
    public required Dictionary<string, CompanyEntry> Companies { get; set; }
}
