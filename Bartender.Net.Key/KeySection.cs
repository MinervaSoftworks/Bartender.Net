using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Section;

namespace Bartender.Net.Key;

public class KeySection : ISection {
    public string Name => "key";

    public static readonly Selection Info = new ("info", AccessLevel.Public, typeof (object));

    public IEnumerable<Selection> Selections {
        get {
            yield return Info;
        }
    }

}
