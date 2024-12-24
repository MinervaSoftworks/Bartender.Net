using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Territory;

public class TerritoryRoot : BartenderEntity {
    [JsonProperty ("territory")]
    [NotMapped]
    public Dictionary<string, FactionTerritory> Territories {
        get => TerritoriesList.ToTornDictionary ();
        set => TerritoriesList = value.TornDictionaryToList ();
    }

    public virtual List<FactionTerritory> TerritoriesList { get; set; } = [];
}
