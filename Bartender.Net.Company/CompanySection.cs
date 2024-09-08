using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Section;

namespace Bartender.Net.Company;

public class CompanySection : ISection {
    public string Name => "company";

    public static readonly Selection Applications = new ("applications", AccessLevel.Limited, typeof (object));
    public static readonly Selection Companies = new ("companies", AccessLevel.Public, typeof (object));
    public static readonly Selection Detailed = new ("detailed", AccessLevel.Limited, typeof (object));
    public static readonly Selection Employees = new ("employees", AccessLevel.Limited, typeof (object));
    public static readonly Selection News = new ("news", AccessLevel.Limited, typeof (object));
    public static readonly Selection Profile = new ("profile", AccessLevel.Public, typeof (object)); // Reused
    public static readonly Selection Stock = new ("stock", AccessLevel.Limited, typeof (object));

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
