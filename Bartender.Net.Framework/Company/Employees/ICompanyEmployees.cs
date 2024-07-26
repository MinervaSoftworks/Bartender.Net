namespace Bartender.Net.Framework.Company.Employees;

public interface ICompanyEmployees {
    IDictionary<string, IEmployee> Employees { get; }
}
