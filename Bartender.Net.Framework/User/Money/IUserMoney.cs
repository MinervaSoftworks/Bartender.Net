namespace Bartender.Net.Framework.User.Money;

public interface IUserMoney : IBartenderEntity {
    int CaymanBank { get; set; }
    ICityBank CityBank { get; set; }
    int CompanyFunds { get; set; }
    int DailyNetworth { get; set; }
    int MoneyOnhand { get; set; }
    int Points { get; set; }
    int VaultAmount { get; set; }
}