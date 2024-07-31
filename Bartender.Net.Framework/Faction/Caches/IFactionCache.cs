namespace Bartender.Net.Framework.Faction.Caches;

public interface IFactionCache : IBartenderEntity {
    string Name { get; set; }
    int Quantity { get; set; }
    int Type { get; set; }
}
