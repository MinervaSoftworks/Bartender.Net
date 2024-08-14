using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeExp;

public class FactionCrimeExperience {
    [JsonProperty ("crimeexp")]
    public required List<int> CrimeExp { get; set; }
}