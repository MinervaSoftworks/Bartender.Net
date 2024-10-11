using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class DonationEntry : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("money_balance")]
    public required int MoneyBalance { get; set; }

    [JsonProperty ("points_balance")]
    public required int PointsBalance { get; set; }
}
