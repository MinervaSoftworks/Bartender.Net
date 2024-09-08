using Newtonsoft.Json;

namespace Bartender.Net.Torn;

public class Item {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("description")]
    public required string Description { get; set; }

    [JsonProperty ("effect")]
    public required string Effect { get; set; }

    [JsonProperty ("requirement")]
    public required string Requirement { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("weapon_type")]
    public required string WeaponType { get; set; }

    [JsonProperty ("buy_price")]
    public required int BuyPrice { get; set; }

    [JsonProperty ("sell_price")]
    public required int SellPrice { get; set; }

    [JsonProperty ("market_value")]
    public required int MarketValue { get; set; }

    [JsonProperty ("circulation")]
    public required int Circulation { get; set; }

    [JsonProperty ("image")]
    public required string Image { get; set; }

    [JsonProperty ("coverage")]
    public Coverage Coverage { get; set; }
}
