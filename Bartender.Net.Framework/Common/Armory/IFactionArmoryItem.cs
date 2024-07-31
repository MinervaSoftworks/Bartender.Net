namespace Bartender.Net.Framework.Common.Armory;

public interface IFactionArmoryItem : IBartenderEntity
{
    string Name { get; set; }
    int Quantity { get; set; }
    int Type { get; set; }
}
