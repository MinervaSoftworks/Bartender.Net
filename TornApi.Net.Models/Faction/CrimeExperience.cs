using Newtonsoft.Json;

public class CrimeExperience {
    [JsonProperty ("crimeexp")]
    public IEnumerable<int> Members { get; set; }
}
