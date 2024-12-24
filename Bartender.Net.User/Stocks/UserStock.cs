using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Stocks;

public class UserStock : BartenderEntity {
    [JsonProperty ("benefit")]
    public virtual required UserStockBonus Benefit { get; set; }

    public int BenefitID { get; set; }

    [JsonProperty ("benefit")]
    public virtual required UserStockBonus Dividend { get; set; }

    public int DividendID { get; set; }

    [JsonProperty ("stock_id")]
    public required int StockId { get; set; }

    [JsonProperty ("total_shares")]
    public required int TotalShares { get; set; }

    [JsonProperty ("transactions")]
    [NotMapped]
    public Dictionary<string, UserStockTransaction> Transactions {
        get => TransactionsList.ToTornDictionary ();
        set => TransactionsList = value.TornDictionaryToList ();
    }

    public virtual List<UserStockTransaction> TransactionsList { get; set; } = [];
}
