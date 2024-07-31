namespace Bartender.Net.Framework.Faction.Donations;

public interface IDonationEntry : IBartenderEntity {
    int MoneyBalance { get; set; }
    string Name { get; set; }
    int PointsBalance { get; set; }
}
