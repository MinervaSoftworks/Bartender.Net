namespace Bartender.Net.Framework.Selection;

public interface ISelection {
    AccessLevel AccessLevelRequired { get; }
    string EndpointString { get; }
    string Name { get; }
    Type SelectionRootType { get; }
}