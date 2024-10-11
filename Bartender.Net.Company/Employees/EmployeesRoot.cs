using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class EmployeesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("company_employees")]
    public required Dictionary<string, Employee> Employees { get; set; }
}
