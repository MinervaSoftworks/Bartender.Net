namespace Bartender.Net.Framework.Faction.Caches;

public interface IFactionCache : IBartenderEntity {
    string Name { get; }
    int Quantity { get; }
    int Type { get; }
}
