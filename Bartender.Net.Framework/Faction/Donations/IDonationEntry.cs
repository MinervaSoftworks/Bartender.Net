namespace Bartender.Net.Framework.Faction.Donations;

public interface IDonationEntry : IBartenderEntity {
    int MoneyBalance { get; }
    string Name { get; }
    int PointsBalance { get; }
}
