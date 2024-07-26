namespace Bartender.Net.Framework.Company.Companies;

public interface ICompanyEntry {
    int CompanyType { get; }
    int DailyCustomers { get; }
    int DailyIncome { get; }
    int DaysOld { get; }
    int Director { get; }
    int EmployeesCapacity { get; }
    int EmployeesHired { get; }
    int ID { get; }
    string Name { get; }
    int Rating { get; }
    int WeeklyCustomers { get; }
    int WeeklyIncome { get; }
}