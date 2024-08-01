﻿using Bartender.Net.Framework.Faction.Donations;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Donations;

public class DonationEntry : IDonationEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("money_balance")]
    public int MoneyBalance { get; set; }

    [JsonProperty ("points_balance")]
    public int PointsBalance { get; set; }
}