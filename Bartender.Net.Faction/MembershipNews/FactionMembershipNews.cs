using Bartender.Net.Framework.Common.News;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttackNews;

public class FactionMembershipNews : INewsEntries {
    [JsonProperty ("membershipnews")]
    public IDictionary<string, INewsEntry> News { get; set; }
}

