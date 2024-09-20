using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Key;

public class KeySelections {
    public static readonly Selection Info = new ("info", AccessLevel.Public, typeof (KeyInfo));

    public static IEnumerable<Selection> Selections {
        get {
            yield return Info;
        }
    }

}
