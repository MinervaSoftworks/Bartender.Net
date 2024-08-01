﻿using Bartender.Net.Framework.Faction.Basic;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class RankedWarFaction : IRankedWarFaction {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("chain")]
    public int Chain { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("score")]
    public int Score { get; set; }
}