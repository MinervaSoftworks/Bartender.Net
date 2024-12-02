using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNewsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("news")]
    public Dictionary<string, NewsEntry> News { get; set; } = default!;

    public virtual List<NewsEntry> NewsList {
        get => News.TornDictionaryToList ();
        set => News = value.ToTornDictionary ();
    }
}
