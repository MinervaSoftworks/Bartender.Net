using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class CompanyEmployees {
    [JsonProperty ("company_employees")]
    public required Dictionary<string, Employee> Employees { get; set; }
}
