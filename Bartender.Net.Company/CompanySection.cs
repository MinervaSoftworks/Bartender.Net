using Bartender.Net.Company.Applications;
using Bartender.Net.Company.Companies;
using Bartender.Net.Company.Detailed;
using Bartender.Net.Company.Employees;
using Bartender.Net.Company.News;
using Bartender.Net.Company.Profile;
using Bartender.Net.Company.Stock;
using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Company;

public class CompanySection : ISection {
    public string Name => "company";

    public static readonly Selection Applications = new ("applications", AccessLevel.Limited, typeof (CompanyApplicationsRoot));
    public static readonly Selection Companies = new ("companies", AccessLevel.Public, typeof (CompaniesRoot));
    public static readonly Selection Detailed = new ("detailed", AccessLevel.Limited, typeof (DetailedRoot));
    public static readonly Selection Employees = new ("employees", AccessLevel.Limited, typeof (EmployeesRoot));
    public static readonly Selection News = new ("news", AccessLevel.Limited, typeof (CompanyNewsRoot));
    public static readonly Selection Profile = new ("profile", AccessLevel.Public, typeof (CompanyProfileRoot));
    public static readonly Selection Stock = new ("stock", AccessLevel.Limited, typeof (StockRoot));

    public IEnumerable<Selection> Selections {
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
