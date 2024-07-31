using Bartender.Net.Framework.Company.News;
using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNews : ICompanyNews {
    [JsonProperty ("news")]
    public IDictionary<string, ICompanyNewsEntry> MyProperty { get; set; }
}
