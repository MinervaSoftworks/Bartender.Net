using Bartender.Net.Framework.Key;

namespace Bartender.Net.Framework.Section;

public interface ISection {
    string Name { get; }

    IEnumerable<Selection> Selections { get; }
}

public record Selection (string Name, AccessLevel AccessLevelRequired, Type Root);
