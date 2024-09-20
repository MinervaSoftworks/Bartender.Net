using Bartender.Net.Company;
using Bartender.Net.Faction;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Key;
using Bartender.Net.Market;
using Bartender.Net.Property;
using Bartender.Net.User;

namespace Bartender.Net;

public static class Sections {
    public static readonly Section Company = new Section ("company", CompanySelections.Selections);
    public static readonly Section Faction = new Section ("faction", FactionSelections.Selections);
    public static readonly Section Key = new Section ("key", KeySelections.Selections);
    public static readonly Section Market = new Section ("market", MarketSelections.Selections);
    public static readonly Section Property = new Section ("property", PropertySelections.Selections);
    public static readonly Section User = new Section ("user", UserSelections.Selections);

    public static IEnumerable<Section> Values {
        get {
            yield return Company;
            yield return Faction;
            yield return Key;
            yield return Market;
            yield return Property;
            yield return User;
        }
    }
}
