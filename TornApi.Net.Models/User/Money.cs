using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Money {
    [JsonProperty("points")]
    public int Points { get; set; }

    [JsonProperty("cayman_bank")]
    public int CaymanBank { get; set; }

    [JsonProperty("vault_amount")]
    public int VaultAmount { get; set; }

    [JsonProperty("company_funds")]
    public int CompanyFunds { get; set; }

    [JsonProperty("daily_networth")]
    public int DailyNetworth { get; set; }

    [JsonProperty("money_onhand")]
    public int MoneyOnhand { get; set; }

    [JsonProperty("city_bank")]
    public CityBank CityBank { get; set; }
}
