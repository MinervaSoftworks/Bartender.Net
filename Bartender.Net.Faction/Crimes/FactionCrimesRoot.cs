using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("crimes")]
    [NotMapped]
    public Dictionary<string, FactionCrime> Crimes { get; set; } = default!;

    public virtual List<FactionCrime> CrimesList {
        get => Crimes.TornDictionaryToList ();
        set => Crimes = value.ToTornDictionary ();
    }
}
