using Newtonsoft.Json;

namespace Bartender.Net.Company.Detailed;

public class CompanyDetails {
    [JsonProperty ("advertising_budget")]
    public int AdvertisingBudget { get; set; }

    [JsonProperty ("company_bank")]
    public int CompanyBank { get; set; }

    [JsonProperty ("company_funds")]
    public int CompanyFunds { get; set; }

    [JsonProperty ("efficiency")]
    public int Efficiency { get; set; }

    [JsonProperty ("environment")]
    public int Environment { get; set; }

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("popularity")]
    public int Popularity { get; set; }

    [JsonProperty ("trains_available")]
    public int TrainsAvailable { get; set; }

    [JsonProperty ("upgrades")]
    public CompanyUpgrades Upgrades { get; set; }

    [JsonProperty ("value")]
    public int Value { get; set; }
}
