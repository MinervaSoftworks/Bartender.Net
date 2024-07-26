using Bartender.Net.Framework.Company.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Profile;

public class CompanyProfile : ICompanyProfile {
    [JsonProperty ("ID")]
    public required int ID { get; set; }

    [JsonProperty ("company_type")]
    public required int CompanyType { get; set; }

    [JsonProperty ("rating")]
    public required int Rating { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("director")]
    public required int Director { get; set; }

    [JsonProperty ("employees_hired")]
    public required int EmployeesHired { get; set; }

    [JsonProperty ("employees_capacity")]
    public required int EmployeesCapacity { get; set; }

    [JsonProperty ("daily_income")]
    public required int DailyIncome { get; set; }

    [JsonProperty ("daily_customers")]
    public required int DailyCustomers { get; set; }

    [JsonProperty ("weekly_income")]
    public required int WeeklyIncome { get; set; }

    [JsonProperty ("weekly_customers")]
    public required int WeeklyCustomers { get; set; }

    [JsonProperty ("days_old")]
    public required int DaysOld { get; set; }

    [JsonProperty ("employees")]
    public required IDictionary<string, ICompanyEmployee> Employees { get; set; }
}
