using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionMembershipNews {
    [JsonProperty ("membershipnews")]
    public required Dictionary<string, NewsEntry> News { get; set; }
}

