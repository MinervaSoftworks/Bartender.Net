using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;

namespace Bartender.Net.Key;

public class KeySection : ISection {
    public int ID => 7;

    public string Name => "key";

    public static readonly Selection Info = new ("info", AccessLevel.Public, typeof (KeyInfo));

    public IEnumerable<Selection> Selections {
        get {
            yield return Info;
        }
    }

}
