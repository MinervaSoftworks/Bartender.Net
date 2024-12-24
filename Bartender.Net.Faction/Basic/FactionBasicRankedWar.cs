using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Basic;

public class FactionBasicRankedWar : BartenderEntity {
    [JsonProperty ("factions")]
    [NotMapped]
    public Dictionary<string, FactionBasicRankedWarFaction> Factions {
        get => FactionsList.ToTornDictionary ();
        set => FactionsList = value.TornDictionaryToList ();
    }

    public virtual List<FactionBasicRankedWarFaction> FactionsList { get; set; } = [];

    [JsonProperty ("war")]
    public virtual required FactionBasicWar War { get; set; }
}
