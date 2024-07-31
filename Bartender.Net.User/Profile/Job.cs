using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Job : IJob {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company_id")]
    public int CompanyID { get => ID; set => ID = value; }

    [JsonProperty ("company_name")]
    public string CompanyName { get; set; }

    [JsonProperty ("company_type")]
    public int Type { get; set; }

    [JsonProperty ("job")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }
}
