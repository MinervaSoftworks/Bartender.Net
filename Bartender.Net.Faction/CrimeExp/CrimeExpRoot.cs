using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeExp;

public class CrimeExpRoot {
    [JsonProperty ("crimeexp")]
    public required List<int> CrimeExp { get; set; }
}