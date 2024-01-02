using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Job {
    public int JobID { get; set; }

    public Profile Owner { get; set; }

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
