using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Key;

public class KeySection {
    public static readonly Selection Info = new ("info", AccessLevel.Public, typeof (KeyInfo), typeof (KeyInfo));

    public static IEnumerable<Selection> Selections {
        get {
            yield return Info;
        }
    }

}
