using Bartender.Net.Framework.Company.News;
using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNews : ICompanyNews {
    [JsonProperty ("news")]
    public required IDictionary<string, ICompanyNewsEntry> MyProperty { get; set; }
}
