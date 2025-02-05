﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Company.Stock;

public class CompanyStock : BartenderEntity {
    [JsonIgnore]
    public string? Name { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("in_stock")]
    public required int InStock { get; set; }

    [JsonProperty ("on_order")]
    public required int OnOrder { get; set; }

    [JsonProperty ("price")]
    public required int Price { get; set; }

    [JsonProperty ("rrp")]
    public required int RRP { get; set; }

    [JsonProperty ("sold_amount")]
    public required int SoldAmount { get; set; }

    [JsonProperty ("sold_worth")]
    public required int SoldWorth { get; set; }
}
