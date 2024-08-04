namespace Bartender.Net.Framework.Selection;

public interface ISection {
    string EndpointString { get; }
    string Name { get; }
    IEnumerable<ISelectionRoot> Selections { get; }
}
