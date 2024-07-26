namespace Bartender.Net.Framework.User.DisplayCase;

public interface IDisplay : IBartenderEntity {
    int Circulation { get; }
    int MarketPrice { get; }
    string Name { get; }
    int Quantity { get; }
    string Type { get; }
    long UID { get; }
}