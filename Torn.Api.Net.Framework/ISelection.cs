namespace Torn.Api.Net.Framework;

public interface ISelection {
    int ID { get; }

    string Name { get; }

    int Section { get; }

    AccessLevel AccessLevel { get; }
}
