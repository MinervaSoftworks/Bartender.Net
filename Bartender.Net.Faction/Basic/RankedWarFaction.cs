﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class RankedWarFaction : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("score")]
    public required int Score { get; set; }
}
