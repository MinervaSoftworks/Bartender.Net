using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class CompanyPoints : ICompanyPoints {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("jobpoints")]
    public required int JobPoints { get; set; }
}
