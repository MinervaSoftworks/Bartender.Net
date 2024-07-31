using Bartender.Net.Framework.Company.Companies;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Companies;

public class CompanyEntries : ICompanyEntries {
    [JsonProperty ("cards")]
    public IDictionary<string, CompanyEntry> Companies { get; set; }
}
