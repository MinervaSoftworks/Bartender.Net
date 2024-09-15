using Bartender.Net.Framework.Key;

namespace Bartender.Net.Framework.Sections;

public interface ISelection {
    string Name { get; }

    AccessLevel AccessLevel { get; }
    string ProperName { get; }
}
