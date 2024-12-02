using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.CrimeNews;

public class CrimeNewsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("crimenews")]
    [NotMapped]
    public Dictionary<string, NewsEntry> News { get; set; } = default!;

    public virtual List<NewsEntry> NewsList {
        get => News.TornDictionaryToList ();
        set => News = value.ToTornDictionary ();
    }
}

