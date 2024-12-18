using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Market.PointsMarket;

public class PointsMarketRoot : BartenderEntity {
    [JsonProperty ("pointsmarket")]
    [NotMapped]
    public Dictionary<string, PointListing> Points { get; set; } = default!;

    public virtual List<PointListing> PointsList {
        get => Points.TornDictionaryToList ();
        set => Points = value.ToTornDictionary ();
    }
}
