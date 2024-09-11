using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNewsRoot {
    [JsonProperty ("news")]
    public required Dictionary<string, CompanyNewsEntry> MyProperty { get; set; }
}
