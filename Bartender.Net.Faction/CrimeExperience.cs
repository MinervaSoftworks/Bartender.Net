using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction; 

public class CrimeExperience {
    public int CrimeEpxerienceID { get; set; }

    [JsonProperty ("crimeexp")]
    public IEnumerable<int> Members { get; set; }
}