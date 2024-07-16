using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class CompanyPoints {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public int CompanyTypeID { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("jobpoints")]
    public int JobPoints { get; set; }
}