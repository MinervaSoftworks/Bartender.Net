using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Stocks;

public class UserStock : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("benefit")]
    public virtual required UserStockBonus Benefit { get; set; }

    [JsonProperty ("benefit")]
    public virtual required UserStockBonus Dividend { get; set; }

    [JsonProperty ("stock_id")]
    public required int StockId { get; set; }

    [JsonProperty ("total_shares")]
    public required int TotalShares { get; set; }

    [JsonProperty ("transactions")]
    [NotMapped]
    public Dictionary<string, UserStockTransaction> Transactions { get; set; } = default!;

    public virtual List<UserStockTransaction> TransactionsList {
        get => Transactions.TornDictionaryToList ();
        set => Transactions = value.ToTornDictionary ();
    }
}
