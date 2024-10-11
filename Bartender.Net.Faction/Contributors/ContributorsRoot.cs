using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Contributors;

// TODO Figure this mess out
public class ContributorsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("contributors")]
    public required StatContributors Contributors { get; set; }
}
