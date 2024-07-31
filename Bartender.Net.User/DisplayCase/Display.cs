using Bartender.Net.Framework.User.DisplayCase;
using Newtonsoft.Json;

namespace Bartender.Net.User.DisplayCase;

public class Display : IDisplay {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("circulation")]
    public int Circulation { get; set; }

    [JsonProperty ("market_price")]
    public int MarketPrice { get; set; }

    [JsonProperty ("UID")]
    public long UID { get; set; }
}
