using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarEntry : BartenderEntity {
    [JsonProperty ("war")]
    public virtual required RankedWar Rankedwar { get; set; }

    [JsonProperty ("factions")]
    [NotMapped]
    public Dictionary<string, RankedWarFaction> Factions { get; set; } = default!;

    public virtual List<RankedWarFaction> FactionsList {
        get => Factions.TornDictionaryToList ();
        set => Factions = value.ToTornDictionary ();
    }
}
