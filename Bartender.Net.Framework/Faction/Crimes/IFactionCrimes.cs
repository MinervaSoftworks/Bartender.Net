namespace Bartender.Net.Framework.Faction.Crimes;

public interface IFactionCrimes {
    IDictionary<string, IFactionCrime> Crimes { get; set; }
}
