using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeExp;

public class CrimeExpRoot : BartenderEntity {
    [JsonProperty ("crimeexp")]
    public required List<int> CrimeExp { get; set; }
}