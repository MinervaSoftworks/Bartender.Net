namespace Bartender.Net.Framework.Section;

public interface ISection {
    string EndpointString { get; }
    string Name { get; }
    IEnumerable<ISelection> Selections { get; }
}
