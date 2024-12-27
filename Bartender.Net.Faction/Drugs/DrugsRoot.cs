using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Drugs;

public class DrugsRoot : BartenderEntity {
    [JsonProperty ("caches")]
    public virtual required List<FactionDrug> Items { get; set; }
}
