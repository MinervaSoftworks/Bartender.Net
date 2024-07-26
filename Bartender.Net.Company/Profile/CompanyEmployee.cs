using Bartender.Net.Framework.Company.Profile;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyEmployee : ICompanyEmployee {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public required int DaysInCompany { get; set; }

    [JsonProperty ("last_action")]
    public required ILastAction LastAction { get; set; }
}
