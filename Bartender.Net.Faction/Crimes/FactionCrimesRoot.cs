using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimesRoot : BartenderEntity {
    [JsonProperty ("crimes")]
    [NotMapped]
    public Dictionary<string, FactionCrime> Crimes {
        get => CrimesList.ToTornDictionary ();
        set => CrimesList = value.TornDictionaryToList ();
    }

    public virtual List<FactionCrime> CrimesList { get; set; } = [];
}
