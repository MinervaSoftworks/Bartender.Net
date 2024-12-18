using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Detailed;

public class DetailedRoot : BartenderEntity {
    [JsonProperty ("advertising_budget")]
    public required int AdvertisingBudget { get; set; }

    [JsonProperty ("company_bank")]
    public required int CompanyBank { get; set; }

    [JsonProperty ("company_funds")]
    public required int CompanyFunds { get; set; }

    [JsonProperty ("efficiency")]
    public required int Efficiency { get; set; }

    [JsonProperty ("environment")]
    public required int Environment { get; set; }

    [JsonProperty ("ID")]    public required int DetailedID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("popularity")]
    public required int Popularity { get; set; }

    [JsonProperty ("trains_available")]
    public required int TrainsAvailable { get; set; }

    [JsonProperty ("upgrades")]
    public required DetailedUpgrade Upgrades { get; set; }

    [JsonProperty ("value")]
    public required int Value { get; set; }
}
