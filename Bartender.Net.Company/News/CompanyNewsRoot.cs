using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNewsRoot {
    [JsonProperty ("news")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}
