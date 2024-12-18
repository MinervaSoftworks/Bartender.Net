using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class CompanyPoints : BartenderEntity {
    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("jobpoints")]
    public required int JobPoints { get; set; }
}
