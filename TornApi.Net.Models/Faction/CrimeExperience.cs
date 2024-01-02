using Newtonsoft.Json;
using TornApi.Net.Models.Faction;

public class CrimeExperience {
    public int CrimeEpxerienceID { get; set; }

    public Basic Faction { get; set; }

    [JsonProperty ("crimeexp")]
    public IEnumerable<int> Members { get; set; }
}
