namespace Bartender.Net.Framework.Company.Detailed;

public interface ICompanyDetails : IBartenderEntity {
    int AdvertisingBudget { get; }
    int CompanyBank { get; }
    int CompanyFunds { get; }
    int Efficiency { get; }
    int Environment { get; }
    int Popularity { get; }
    int TrainsAvailable { get; }
    ICompanyUpgrades Upgrades { get; }
    int Value { get; }
}