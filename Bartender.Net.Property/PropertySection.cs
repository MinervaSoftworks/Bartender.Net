using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Property.Property;

namespace Bartender.Net.Property;

public class PropertySection {
    public static readonly Selection Property = new ("property", AccessLevel.Public, typeof (PropertyRoot), typeof (PropertyEntry));

    public static IEnumerable<Selection> Selections {
        get {
            yield return Property;
        }
    }
}
