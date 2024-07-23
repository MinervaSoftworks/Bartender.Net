namespace Bartender.Net.Framework.User.DisplayCase;

public interface IDisplay : IBartenderEntity {
    int Circulation { get; set; }
    int MarketPrice { get; set; }
    string Name { get; set; }
    int Quantity { get; set; }
    string Type { get; set; }
    long UID { get; set; }
}