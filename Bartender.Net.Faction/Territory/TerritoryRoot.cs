using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Territory;

public class TerritoryRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("territory")]
    [NotMapped]
    public Dictionary<string, FactionTerritory> Territories { get; set; } = default!;

    public virtual List<FactionTerritory> TerritoriesList {
        get => Territories.TornDictionaryToList ();
        set => Territories = value.ToTornDictionary ();
    }
}
