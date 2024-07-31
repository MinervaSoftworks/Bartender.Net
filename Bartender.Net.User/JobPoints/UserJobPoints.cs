using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class UserJobPoints : IUserJobPoints {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("army")]
    public int? Army { get; set; }

    [JsonProperty ("casino")]
    public int? Casino { get; set; }

    [JsonProperty ("education")]
    public int? Education { get; set; }

    [JsonProperty ("grocer")]
    public int? Grocer { get; set; }

    [JsonProperty ("law")]
    public int? Law { get; set; }

    [JsonProperty ("medical")]
    public int? Medical { get; set; }
}
