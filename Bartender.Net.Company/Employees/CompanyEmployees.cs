using Bartender.Net.Framework.Company.Employees;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Employees;

public class CompanyEmployees : ICompanyEmployees {
    [JsonProperty ("company_employees")]
    public required IDictionary<string, IEmployee> Employees { get; set; }
}
