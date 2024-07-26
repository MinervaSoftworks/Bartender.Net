namespace Bartender.Net.Framework.User.Money;

public interface ICityBank : IBartenderEntity {
    int Amount { get; }
    int TimeLeft { get; }
}