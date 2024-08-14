using Bartender.Net.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class Employee {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("position")]
    public required string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public required int DaysInCompany { get; set; }

    [JsonProperty ("manual_labor")]
    public required int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public required int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public required int Endurance { get; set; }

    [JsonProperty ("effectiveness")]
    public required Effectiveness Effectiveness { get; set; }

    [JsonProperty ("last_action")]
    public required LastAction LastAction { get; set; }

    [JsonProperty ("status")]
    public required Status Status { get; set; }
}
