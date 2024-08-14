using Newtonsoft.Json;

namespace Bartender.Net.Company.Companies;

public class CompanyEntries {
    [JsonProperty ("cards")]
    public required Dictionary<string, CompanyEntry> Companies { get; set; }
}
