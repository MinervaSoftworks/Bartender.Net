using Bartender.Net.Framework.Company.Profile;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyEmployee : ICompanyEmployee {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public int DaysInCompany { get; set; }

    [JsonProperty ("last_action")]
    public ILastAction LastAction { get; set; }
}
