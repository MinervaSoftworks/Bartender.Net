using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Job {
    [JsonIgnore]
    public int ID { get; set; }

    public int JobID { get; set; }

    [JsonProperty ("company_id")]
    public int CompanyID { get; set; }

    [JsonProperty ("company_name")]
    public string CompanyName { get; set; }

    [JsonProperty ("company_type")]
    public int Type { get; set; }

    [JsonProperty ("job")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }
}
