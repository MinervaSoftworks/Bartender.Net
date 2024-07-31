using Newtonsoft.Json;

namespace Bartender.Net.Framework.Faction.CrimeExp;

public interface IFactionCrimeExperience {
    [JsonProperty ("crimeexp")]
    IEnumerable<int> CrimeExp { get; set; }
}
