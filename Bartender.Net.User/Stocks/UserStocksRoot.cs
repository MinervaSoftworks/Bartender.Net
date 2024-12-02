using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Stocks;

public class UserStocksRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("stocks")]
    [NotMapped]
    public Dictionary<string, UserStock> Stocks { get; set; } = default!;

    public virtual List<UserStock> StocksList {
        get => Stocks.TornDictionaryToList ();
        set => Stocks = value.ToTornDictionary ();
    }
}
