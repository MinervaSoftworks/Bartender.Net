using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class JobPointsCollection : IJobPointsCollection {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("companies")]
    public IDictionary<string, ICompanyPoints> Companies { get; set; }

    [JsonProperty ("jobs")]
    public IUserJobPoints JobPoints { get; set; }
}
