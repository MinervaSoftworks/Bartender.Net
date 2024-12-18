using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.RankedWars;

public class RankedWarsRoot : BartenderEntity {
    [JsonProperty ("rankedwars")]
    [NotMapped]
    public Dictionary<string, RankedWarEntry> Wars { get; set; } = default!;

    public virtual List<RankedWarEntry> WarsList {
        get => Wars.TornDictionaryToList ();
        set => Wars = value.ToTornDictionary ();
    }
}
