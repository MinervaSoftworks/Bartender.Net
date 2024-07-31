using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionMembershipNews : IFactionNews {
    [JsonProperty ("membershipnews")]
    public IDictionary<string, IFactionNewsEntry> News { get; set; }
}

