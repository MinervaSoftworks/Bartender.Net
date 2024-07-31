using Bartender.Net.Framework.Faction.Contributors;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributorsCollectionn : IFactionStatContributorsCollectionn {
    [JsonProperty ("contributors")]
    public IFactionStatContributors Contributors { get; set; }
}
