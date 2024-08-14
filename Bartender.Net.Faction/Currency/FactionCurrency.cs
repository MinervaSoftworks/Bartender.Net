using Newtonsoft.Json;

namespace Bartender.Net.Faction.Currency;

public class FactionCurrency {
    [JsonProperty ("faction_id")]
    public int FactionId { get; set; }

    [JsonProperty ("points")]
    public int Points { get; set; }

    [JsonProperty ("money")]
    public int Money { get; set; }
}
