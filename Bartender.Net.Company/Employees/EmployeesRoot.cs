using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class EmployeesRoot {
    [JsonProperty ("company_employees")]
    public required Dictionary<string, Employee> Employees { get; set; }
}
