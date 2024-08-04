namespace Bartender.Net.Framework.Company.Profile;

public interface ICompanyProfile : IBartenderEntity {
    int CompanyType { get; }
    int DailyCustomers { get; }
    int DailyIncome { get; }
    int DaysOld { get; }
    int Director { get; }
    IDictionary<string, ICompanyEmployee> Employees { get; }
    int EmployeesCapacity { get; }
    int EmployeesHired { get; }
    string Name { get; }
    int Rating { get; }
    int WeeklyCustomers { get; }
    int WeeklyIncome { get; }
}
