using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Job : BartenderEntity {
    [JsonProperty ("company_id")]
    public required int CompanyID { get; set; }

    [JsonProperty ("company_name")]
    public required string CompanyName { get; set; }

    [JsonProperty ("company_type")]
    public required int Type { get; set; }

    [JsonProperty ("job")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }
}
