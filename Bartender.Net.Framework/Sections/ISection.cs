using Bartender.Net.Framework.Key;

namespace Bartender.Net.Framework.Sections;

public interface ISection {
    string Name { get; }

    IEnumerable<Selection> Selections { get; }
}

public record Selection (string Name, AccessLevel AccessLevelRequired, Type Root);
