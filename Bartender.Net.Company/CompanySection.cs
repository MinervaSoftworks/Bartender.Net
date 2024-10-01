using Bartender.Net.Company.Applications;
using Bartender.Net.Company.Companies;
using Bartender.Net.Company.Detailed;
using Bartender.Net.Company.Employees;
using Bartender.Net.Company.News;
using Bartender.Net.Company.Profile;
using Bartender.Net.Company.Stock;
using Bartender.Net.Framework.Common.News;
using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Company;

public class CompanySection {
    public static readonly Selection Applications = new ("applications", AccessLevel.Limited, typeof (CompanyApplicationsRoot), typeof (CompanyApplication));
    public static readonly Selection Companies = new ("companies", AccessLevel.Public, typeof (CompaniesRoot), typeof (CompanyEntry));
    public static readonly Selection Detailed = new ("detailed", AccessLevel.Limited, typeof (DetailedRoot), typeof (DetailedRoot));
    public static readonly Selection Employees = new ("employees", AccessLevel.Limited, typeof (EmployeesRoot), typeof (Employee));
    public static readonly Selection News = new ("news", AccessLevel.Limited, typeof (CompanyNewsRoot), typeof (NewsEntry));
    public static readonly Selection Profile = new ("profile", AccessLevel.Public, typeof (CompanyProfileRoot), typeof (CompanyProfile));
    public static readonly Selection Stock = new ("stock", AccessLevel.Limited, typeof (StockRoot), typeof (CompanyStock));

    public static IEnumerable<Selection> Selections {
        get {
            yield return Applications;
            yield return Companies;
            yield return Detailed;
            yield return Employees;
            yield return News;
            yield return Profile;
            yield return Stock;
        }
    }
}
