using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Property.Property;

namespace Bartender.Net.Property;

public class PropertySection : ISection {
    public string Name => "Property";

    public static readonly Selection Property = new ("property", AccessLevel.Public, typeof (PropertyRoot));

    public IEnumerable<Selection> Selections {
        get {
            yield return Property;
        }
    }
}
