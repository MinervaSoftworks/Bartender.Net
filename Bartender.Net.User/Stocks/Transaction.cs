﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Stocks;

public class Transaction {
    [JsonProperty ("shares")]
    public required int Shares { get; set; }

    [JsonProperty ("bought_price")]
    public required double BoughtPrice { get; set; }

    [JsonProperty ("time_bought")]
    public required long TimeBought { get; set; }
}