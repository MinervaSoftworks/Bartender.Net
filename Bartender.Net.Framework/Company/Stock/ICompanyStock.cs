namespace Bartender.Net.Framework.Company.Stock;

public interface ICompanyStock : IBartenderEntity {
    int Cost { get; set; }
    int InStock { get; set; }
    int OnOrder { get; set; }
    int Price { get; set; }
    int RRP { get; set; }
    int SoldAmount { get; set; }
    int SoldWorth { get; set; }
    string Name { get; set; }
}
