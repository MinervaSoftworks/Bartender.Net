using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class CompanyEmployees {
    [JsonProperty ("company_employees")]
    public Dictionary<string, Employee> Employees { get; set; }
}
