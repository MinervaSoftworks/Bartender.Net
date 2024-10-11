using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Revives;

public class FactionRevivesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("revives")]
    public virtual required List<Revive> Revives { get; set; }
}
