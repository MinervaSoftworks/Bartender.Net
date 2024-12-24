using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionAttackNewsRoot : BartenderEntity {
    [JsonProperty ("attacknews")]
    public Dictionary<string, NewsEntry> News {
        get => NewsList. ToTornDictionary();
        set => NewsList = value. TornDictionaryToList();
    }

    public virtual List<NewsEntry> NewsList { get; set; } = [];
}

