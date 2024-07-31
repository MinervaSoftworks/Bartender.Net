using Bartender.Net.Framework.Faction.CrimeExp;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.CrimeExp;

public class FactionCrimeExperience : IFactionCrimeExperience {
    [JsonProperty ("crimeexp")]
    public IEnumerable<int> CrimeExp { get; set; }
}