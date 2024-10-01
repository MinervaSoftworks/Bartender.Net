using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeExp;

public class CrimeExpRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("crimeexp")]
    public required List<int> CrimeExp { get; set; }
}