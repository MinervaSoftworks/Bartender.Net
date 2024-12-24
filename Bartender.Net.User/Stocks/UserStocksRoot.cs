using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Stocks;

public class UserStocksRoot : BartenderEntity {
    [JsonProperty ("stocks")]
    [NotMapped]
    public Dictionary<string, UserStock> Stocks {
        get => StocksList.ToTornDictionary ();
        set => StocksList = value.TornDictionaryToList ();
    }

    public virtual List<UserStock> StocksList { get; set; } = [];
}
