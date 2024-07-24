using Bartender.Net.Framework.User.JobPoints;
using Newtonsoft.Json;

namespace Bartender.Net.User.JobPoints;

public class CompanyPointsCollection : ICompanyPointsCollection {
    [JsonProperty ("companies")]
    public required IDictionary<string, CompanyPoints> CompanyPoints { get; set; }
}
