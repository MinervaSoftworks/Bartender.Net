using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class UserStockBonus : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("ready")]
    public required int Ready { get; set; }

    [JsonProperty ("increment")]
    public required int Increment { get; set; }

    [JsonProperty ("progress")]
    public required int Progress { get; set; }

    [JsonProperty ("frequency")]
    public required int Frequency { get; set; }

    public virtual UserStock BenefitStock { get; set; } = default!;

    public virtual UserStock DividendStock { get; set; } = default!;
}
