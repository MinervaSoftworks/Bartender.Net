using Newtonsoft.Json;

namespace Bartender.Net.User.Money;

public class MoneyRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("points")]
    public required int Points { get; set; }

    [JsonProperty ("cayman_bank")]
    public required int CaymanBank { get; set; }

    [JsonProperty ("vault_amount")]
    public required int VaultAmount { get; set; }

    [JsonProperty ("company_funds")]
    public required int CompanyFunds { get; set; }

    [JsonProperty ("daily_networth")]
    public required int DailyNetworth { get; set; }

    [JsonProperty ("money_onhand")]
    public required int MoneyOnhand { get; set; }

    [JsonProperty ("city_bank")]
    public required CityBank CityBank { get; set; }
}
