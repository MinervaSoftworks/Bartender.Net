using Bartender.Net.Framework.Company.Employees;
using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class Employee : IEmployee {
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
    public IEffectiveness Effectiveness { get; set; }

    [JsonProperty ("last_action")]
    public ILastAction LastAction { get; set; }

    [JsonProperty ("status")]
    public IStatus Status { get; set; }
}
