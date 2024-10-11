using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.FundsNews;

public class FundsNewsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("fundsnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

