namespace Bartender.Net.Framework.Sections;

public class Selection {
    public string Name { get; }

    public string EndpointString { get; }

    public AccessLevel AccessLevelRequired { get; }

    internal Selection (string name, string endpointString, AccessLevel accessLevelRequired) {
        Name = name;
        EndpointString = endpointString;
        AccessLevelRequired = accessLevelRequired;
    }
}

public static class UserSection {

}

public static class PropertySection {

}

public static class FactionSection {

}

public static class CompanySection {

}

public static class MarketSection {

}

public static class TornSection {
}

public static class KeySection {
    public static readonly Selection Info = new Selection ("Info", "info", AccessLevel.Public);

    public static IEnumerable<Selection> Values {
        get {
            yield return Info;
        }
    }
}
