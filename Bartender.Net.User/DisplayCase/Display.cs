using Newtonsoft.Json;

namespace Bartender.Net.User.DisplayCase;

public class Display {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("circulation")]
    public required int Circulation { get; set; }

    [JsonProperty ("market_price")]
    public required int MarketPrice { get; set; }

    [JsonProperty ("UID")]
    public long UID { get; set; }
}
