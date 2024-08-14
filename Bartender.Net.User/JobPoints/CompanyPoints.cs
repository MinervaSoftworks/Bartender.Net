using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class CompanyPoints {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("jobpoints")]
    public int JobPoints { get; set; }
}
