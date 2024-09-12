using Newtonsoft.Json;

namespace Bartender.Net.Company.Detailed;

public class DetailedRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

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

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("popularity")]
    public required int Popularity { get; set; }

    [JsonProperty ("trains_available")]
    public required int TrainsAvailable { get; set; }

    [JsonProperty ("upgrades")]
    public required Upgrade Upgrades { get; set; }

    [JsonProperty ("value")]
    public required int Value { get; set; }
}
