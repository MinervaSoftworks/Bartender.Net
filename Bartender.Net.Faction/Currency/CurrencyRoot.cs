using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Currency;

public class CurrencyRoot : BartenderEntity {
    [JsonProperty ("faction_id")]
    public required int FactionID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("points")]
    public required int Points { get; set; }

    [JsonProperty ("money")]
    public required long Money { get; set; }
}
