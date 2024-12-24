using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.FundsNews;

public class FundsNewsRoot : BartenderEntity {
    [JsonProperty ("fundsnews")]
    [NotMapped]
    public Dictionary<string, NewsEntry> News {
        get => NewsList.ToTornDictionary ();
        set => NewsList = value.TornDictionaryToList ();
    }

    public virtual List<NewsEntry> NewsList { get; set; } = default!;
}

