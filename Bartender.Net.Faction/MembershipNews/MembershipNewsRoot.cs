using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.MembershipNews;

public class MembershipNewsRoot {
    [JsonProperty ("membershipnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

