using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.TerritoryNews;

public class TerritoryNewsRoot : BartenderEntity {
    [JsonProperty ("territorynews")]
    [NotMapped]
    public Dictionary<string, NewsEntry> News {
        get => NewsList.ToTornDictionary ();
        set => NewsList = value.TornDictionaryToList ();
    }

    public virtual List<NewsEntry> NewsList { get; set; } = [];
}

