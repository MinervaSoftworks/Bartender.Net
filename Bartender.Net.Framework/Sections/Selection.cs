using Bartender.Net.Framework.Key;

namespace Bartender.Net.Framework.Sections;

public record Selection (string Name, AccessLevel AccessLevelRequired, Type JsonRootType, Type EntityType);
