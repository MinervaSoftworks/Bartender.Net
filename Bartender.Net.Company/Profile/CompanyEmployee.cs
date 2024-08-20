using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyEmployee {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public required int DaysInCompany { get; set; }

    [JsonProperty ("last_action")]
    public required LastAction LastAction { get; set; }
}
