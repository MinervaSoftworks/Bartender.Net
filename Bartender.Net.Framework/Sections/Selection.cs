using Bartender.Net.Framework.Key;

namespace Bartender.Net.Framework.Sections;

public record Selection (Section Section, string Name, AccessLevel AccessLevelRequired, Type JsonRootType, Type EntityType);
