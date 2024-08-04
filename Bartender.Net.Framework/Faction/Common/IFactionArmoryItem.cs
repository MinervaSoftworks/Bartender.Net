namespace Bartender.Net.Framework.Faction.Common;

public interface IFactionArmoryItem : IBartenderEntity {
    string Name { get; }
    int Quantity { get; }
    int Type { get; }
}
