using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.MembershipNews;

public class MembershipNewsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("membershipnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

