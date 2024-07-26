namespace Bartender.Net.Framework.Company.Profile;

public interface ICompanyProfile : IBartenderEntity {
    int CompanyType { get; set; }
    int DailyCustomers { get; set; }
    int DailyIncome { get; set; }
    int DaysOld { get; set; }
    int Director { get; set; }
    IDictionary<string, ICompanyEmployee> Employees { get; set; }
    int EmployeesCapacity { get; set; }
    int EmployeesHired { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    int WeeklyCustomers { get; set; }
    int WeeklyIncome { get; set; }
}
