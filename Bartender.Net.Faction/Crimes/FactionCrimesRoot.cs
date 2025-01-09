using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Crimes;

public class FactionCrimesRoot : BartenderEntity {
    [JsonProperty ("crimes")]
    [NotMapped]
    public Dictionary<string, FactionCrime> Crimes { get; set; } = [];

    public virtual List<FactionCrime> CrimesList { get; set; } = [];
}
