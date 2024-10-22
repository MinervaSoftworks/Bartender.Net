﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Currency;

public class CurrencyRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("faction_id")]
    public required int FactionId { get; set; }

    [JsonProperty ("points")]
    public required int Points { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }
}
