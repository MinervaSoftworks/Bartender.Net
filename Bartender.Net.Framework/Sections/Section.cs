namespace Bartender.Net.Framework.Sections;

public abstract class Section (string name) {
    public string Name { get; init; } = name;

    public abstract IEnumerable<Selection> Selections { get; }
}