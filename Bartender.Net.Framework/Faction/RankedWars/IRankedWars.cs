namespace Bartender.Net.Faction.RankedWars;

public interface IRankedWars {
    IDictionary<string, IRankedWarEntry> Wars { get; set; }
}
