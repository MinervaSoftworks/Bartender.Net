namespace Torn.Api.Net.Framework;

public interface ISection {
    int ID { get; }

    string Name { get; }

    IEnumerable<ISelection> Selections { get; }
}
