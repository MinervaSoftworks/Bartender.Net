namespace Bartender.Net.Framework.Faction.Caches;

public interface IFactionCaches {
    IEnumerable<IFactionCache> Boosters { get; }
}