namespace Bartender.Net.Framework.User.Travel;

public interface ITravelEntry : IBartenderEntity {
    int Departed { get; }
    string Destination { get; }
    string Method { get; }
    int TimeLeft { get; }
    int Timestamp { get; }
}