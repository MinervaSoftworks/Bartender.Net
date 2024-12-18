using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class EmployeesRoot : BartenderEntity {
    [JsonProperty ("company_employees")]
    public Dictionary<string, Employee> Employees { get; set; } = default!;

    public virtual List<Employee> EmployeesList {
        get => Employees.TornDictionaryToList ();
        set => Employees = value.ToTornDictionary ();
    }
}
