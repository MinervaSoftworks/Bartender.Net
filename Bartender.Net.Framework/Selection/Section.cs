namespace Bartender.Net.Framework.Selection;

public class Section {
    public string Name { get; }

    public string EndpointString { get; }

    public IEnumerable<Selection> Selections { get; }

    public static readonly Section User = new Section ("User", "user", new List<Selection> {
    });

    public static readonly Section Property = new Section ("User", "property", new List<Selection> {
    });

    public static readonly Section Faction = new Section ("User", "faction", new List<Selection> {
    });

    public static readonly Section Company = new Section ("User", "company", new List<Selection> {
    });

    public static readonly Section Market = new Section ("User", "market", new List<Selection> {
    });

    public static readonly Section Torn = new Section ("User", "torn", new List<Selection> {
        new Selection ("Bank", "bank", AccessLevel.Public)
    });

    public static readonly Section Key = new Section ("User", "key", new List<Selection> {
    });

    public static IEnumerable<Section> Values {
        get {
            yield return User;
            yield return Property;
            yield return Faction;
            yield return Company;
            yield return Market;
            yield return Torn;
            yield return Key;
        }
    }

    private Section (string name, string endpointString, IEnumerable<Selection> selections) {
        Name = name;
        EndpointString = endpointString;
        Selections = selections;
    }
}
