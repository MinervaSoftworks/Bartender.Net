using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

public class FactionStatContributorsCollectionn {
    [JsonProperty ("contributors")]
    public FactionStatContributors Contributors { get; set; }
}
