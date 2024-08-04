namespace Bartender.Net.Framework.Company.Stock;

public interface ICompanyStock : IBartenderEntity {
    int Cost { get; }
    int InStock { get; }
    int OnOrder { get; }
    int Price { get; }
    int RRP { get; }
    int SoldAmount { get; }
    int SoldWorth { get; }
    string Name { get; }
}
