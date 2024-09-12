using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class EmployeesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company_employees")]
    public required Dictionary<string, Employee> Employees { get; set; }
}
