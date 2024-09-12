namespace Bartender.Net.Company.Stock;

public class StockRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    public required Dictionary<string, CompanyStock> Stocks { get; set; }
}
