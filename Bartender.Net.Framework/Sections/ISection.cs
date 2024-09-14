namespace Bartender.Net.Framework.Sections;

public interface ISection {
    string Name { get; }

    IEnumerable<Selection> Selections { get; }
}
