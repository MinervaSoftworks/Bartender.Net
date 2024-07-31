namespace Bartender.Net.Framework.Faction.Common;

public interface IFactionArmoryItem : IBartenderEntity {
    string Name { get; set; }
    int Quantity { get; set; }
    int Type { get; set; }
}
