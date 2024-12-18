using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Basic;

public class FactionBasicRankedWar : BartenderEntity {
    [JsonProperty ("factions")]
    [NotMapped]
    public Dictionary<string, FactionBasicRankedWarFaction> Factions { get; set; } = default!;

    public virtual List<FactionBasicRankedWarFaction> FactionsList {
        get => Factions.TornDictionaryToList ();
        set => Factions = value.ToTornDictionary ();
    }

    [JsonProperty ("war")]
    public virtual required FactionBasicWar War { get; set; }
}
