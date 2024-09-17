namespace Bartender.Net.Framework.Sections;

public interface ISection : IBartenderEntity {
    string Name { get; }

    IEnumerable<Selection> Selections { get; }
}
