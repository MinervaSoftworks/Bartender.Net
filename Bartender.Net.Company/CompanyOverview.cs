using Bartender.Net.Company.Applications;
using Bartender.Net.Company.Companies;
using Bartender.Net.Company.Detailed;
using Bartender.Net.Company.Employees;
using Bartender.Net.Company.News;
using Bartender.Net.Company.Profile;
using Bartender.Net.Company.Stock;
using Bartender.Net.Framework;

namespace Bartender.Net.Company;

public class CompanyOverview : IBartenderEntity {
    public required int ID { get; set; }

    public required CompanyApplicationsRoot CompanyApplications { get; set; }

    public required CompaniesRoot Companies { get; set; }

    public required DetailedRoot Detailed { get; set; }

    public required EmployeesRoot Employees { get; set; }

    public required CompanyNewsRoot CompanyNews { get; set; }

    public required CompanyProfileRoot CompanyProfile { get; set; }

    public required StockRoot Stock { get; set; }
}
