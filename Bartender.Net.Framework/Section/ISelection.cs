namespace Bartender.Net.Framework.Section;

public interface ISelection {
    AccessLevel AccessLevelRequired { get; }
    string EndpointString { get; }
    string Name { get; }
    Type SelectionRootType { get; }
}