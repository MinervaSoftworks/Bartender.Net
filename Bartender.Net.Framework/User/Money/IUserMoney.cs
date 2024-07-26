namespace Bartender.Net.Framework.User.Money;

public interface IUserMoney : IBartenderEntity {
    int CaymanBank { get; }
    ICityBank CityBank { get; }
    int CompanyFunds { get; }
    int DailyNetworth { get; }
    int MoneyOnhand { get; }
    int Points { get; }
    int VaultAmount { get; }
}