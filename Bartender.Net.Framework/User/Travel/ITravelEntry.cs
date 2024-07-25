namespace Bartender.Net.Framework.User.Travel;

public interface ITravelEntry : IBartenderEntity {
    int Departed { get; set; }
    string Destination { get; set; }
    string Method { get; set; }
    int TimeLeft { get; set; }
    int Timestamp { get; set; }
}