using Bartender.Net.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class Employee {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("position")]
    public string Position { get; set; }

    [JsonProperty ("days_in_company")]
    public int DaysInCompany { get; set; }

    [JsonProperty ("manual_labor")]
    public int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public int Endurance { get; set; }

    [JsonProperty ("effectiveness")]
    public Effectiveness Effectiveness { get; set; }

    [JsonProperty ("last_action")]
    public LastAction LastAction { get; set; }

    [JsonProperty ("status")]
    public Status Status { get; set; }
}
