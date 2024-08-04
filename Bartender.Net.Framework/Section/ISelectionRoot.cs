namespace Bartender.Net.Framework.Selection;

public interface ISelectionRoot {
    AccessLevel AccessLevelRequired { get; }
    string EndpointString { get; }
    string Name { get; }
}