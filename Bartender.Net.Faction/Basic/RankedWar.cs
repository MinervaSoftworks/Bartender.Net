using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Basic;

public class RankedWar : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("factions")]
    [NotMapped]
    public Dictionary<string, RankedWarFaction> Factions { get; set; } = default!;

    public virtual List<RankedWarFaction> FactionsList {
        get => Factions.TornDictionaryToList ();
        set => Factions = value.ToTornDictionary ();
    }

    [JsonProperty ("war")]
    public virtual required War War { get; set; }
}
