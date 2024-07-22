using Newtonsoft.Json;

namespace Bartender.Net.User.Equipable;

public class Equipment {
    [JsonProperty ("equipped")]
    public required int Equiped { get; set; }

    [JsonProperty ("ID")]
    public required int ID { get; set; }

    [JsonProperty ("market_price")]
    public required int MarketPrice { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("UID")]
    public required int UID { get; set; }
}
