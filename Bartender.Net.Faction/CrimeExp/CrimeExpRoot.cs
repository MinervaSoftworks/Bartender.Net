using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeExp;

public class CrimeExpRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("crimeexp")]
    public required List<int> CrimeExp { get; set; }
}