using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class UserJobPoints : IUserJobPoints {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("army")]
    public required int? Army { get; set; }

    [JsonProperty ("casino")]
    public required int? Casino { get; set; }

    [JsonProperty ("education")]
    public required int? Education { get; set; }

    [JsonProperty ("grocer")]
    public required int? Grocer { get; set; }

    [JsonProperty ("law")]
    public required int? Law { get; set; }

    [JsonProperty ("medical")]
    public required int? Medical { get; set; }
}
