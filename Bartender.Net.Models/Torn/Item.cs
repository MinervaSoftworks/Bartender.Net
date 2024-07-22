using Newtonsoft.Json;

namespace TornApi.Net.Models.Torn;

public class Item {
    [JsonIgnore]
    public int ID { get; set; }
    
    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("description")]
    public string Description { get; set; }

    [JsonProperty ("effect")]
    public string Effect { get; set; }

    [JsonProperty ("requirement")]
    public string Requirement { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("weapon_type")]
    public string WeaponType { get; set; }

    [JsonProperty ("buy_price")]
    public int BuyPrice { get; set; }

    [JsonProperty ("sell_price")]
    public int SellPrice { get; set; }

    [JsonProperty ("market_value")]
    public int MarketValue { get; set; }

    [JsonProperty ("circulation")]
    public int Circulation { get; set; }

    [JsonProperty ("image")]
    public string Image { get; set; }

    [JsonProperty ("coverage")]
    public Coverage Coverage { get; set; }
}
