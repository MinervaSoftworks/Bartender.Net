namespace Bartender.Net.Framework.Selection;

public class Selection {
    public string Name { get; }

    public string EndpointString { get; }

    public AccessLevel AccessLevelRequired { get; }

    internal Selection (string name, string endpointString, AccessLevel accessLevelRequired) {
        Name = name;
        EndpointString = endpointString;
        AccessLevelRequired = accessLevelRequired;
    }

    /// <summary>
    /// Return a string in the format $"/{EndpointString}".
    /// </summary>
    public override string ToString () => $"/{EndpointString}";
}
