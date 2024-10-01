using Bartender.Net.Company.Applications;
using Bartender.Net.Company.Companies;
using Bartender.Net.Company.Detailed;
using Bartender.Net.Company.Employees;
using Bartender.Net.Company.News;
using Bartender.Net.Company.Profile;
using Bartender.Net.Company.Stock;

namespace Bartender.Net.Company;

public record CompanyOverview (CompanyApplicationsRoot? CompanyApplications = null,
                               CompaniesRoot? Companies = null,
                               DetailedRoot? Detailed = null,
                               EmployeesRoot? Employees = null,
                               CompanyNewsRoot? CompanyNews = null,
                               CompanyProfileRoot? CompanyProfile = null,
                               CompanyStocksRoot? Stock = null);
