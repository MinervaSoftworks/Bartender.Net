namespace Bartender.Net.Framework.Common.Armory;

public interface IFactionArmoryItems
{
    IEnumerable<IFactionArmoryItem> Items { get; set; }
}