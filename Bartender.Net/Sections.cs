using Bartender.Net.Company;
using Bartender.Net.Faction;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Key;
using Bartender.Net.Market;
using Bartender.Net.Property;
using Bartender.Net.User;

namespace Bartender.Net;

public static class Sections {
    public static readonly Section Company = new Section ("company", CompanySection.Selections);
    public static readonly Section Faction = new Section ("faction", FactionSection.Selections);
    public static readonly Section Key = new Section ("key", KeySection.Selections);
    public static readonly Section Market = new Section ("market", MarketSection.Selections);
    public static readonly Section Property = new Section ("property", PropertySection.Selections);
    public static readonly Section User = new Section ("user", UserSection.Selections);

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
