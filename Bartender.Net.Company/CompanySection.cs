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

public class CompanySection : Section {
    private static CompanySection _instance = default!;

    private readonly static object _lock = new ();

    public static CompanySection Instance {
        get {
            if (_instance == null) {
                lock (_lock) { 
                    _instance ??= new CompanySection ();
                }
            }

            return _instance;
        }
    }

    public readonly Selection Applications;
    public readonly Selection Companies;
    public readonly Selection Detailed;
    public readonly Selection Employees;
    public readonly Selection News;
    public readonly Selection Profile;
    public readonly Selection Stock;

    public override IEnumerable<Selection> Selections {
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

    public CompanySection () : base ("company") {
        Applications = new (this, "applications", AccessLevel.Limited, typeof (CompanyApplicationsRoot), typeof (CompanyApplication));
        Companies = new (this, "companies", AccessLevel.Public, typeof (CompaniesRoot), typeof (CompanyEntry));
        Detailed = new (this, "detailed", AccessLevel.Limited, typeof (DetailedRoot), typeof (DetailedRoot));
        Employees = new (this, "employees", AccessLevel.Limited, typeof (EmployeesRoot), typeof (Employee));
        News = new (this, "news", AccessLevel.Limited, typeof (CompanyNewsRoot), typeof (NewsEntry));
        Profile = new (this, "profile", AccessLevel.Public, typeof (CompanyProfileRoot), typeof (CompanyProfile));
        Stock = new (this, "stock", AccessLevel.Limited, typeof (CompanyStocksRoot), typeof (CompanyStock));
    }
}
