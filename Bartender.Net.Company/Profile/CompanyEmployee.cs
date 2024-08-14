using Bartender.Net.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyEmployee {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public int DaysInCompany { get; set; }

    [JsonProperty ("last_action")]
    public LastAction LastAction { get; set; }
}
