using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeNews;

public class CrimeNewsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("crimenews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

