using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.Property.Property;

namespace Bartender.Net.Property;

public class PropertySection : Section {
    private static PropertySection _instance = default!;

    private readonly static object _lock = new ();

    public static PropertySection Instance {
        get {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new PropertySection ();
                }
            }

            return _instance;
        }
    }

    public readonly Selection Property;

    public override IEnumerable<Selection> Selections {
        get {
            yield return Property;
        }
    }

    private PropertySection () : base ("property") {
        Property = new (this, "property", AccessLevel.Public, typeof (PropertyRoot), typeof (PropertyEntry));
    }
}
