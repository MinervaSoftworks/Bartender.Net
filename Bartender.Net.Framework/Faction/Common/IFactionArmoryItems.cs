namespace Bartender.Net.Framework.Faction.Common;

public interface IFactionArmoryItems {
    IEnumerable<IFactionArmoryItem> Items { get; set; }
}