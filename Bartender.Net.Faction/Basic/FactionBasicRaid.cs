﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Basic;

public class FactionBasicRaid : BartenderEntity {
    [JsonProperty ("defender_score")]
    public required int DefenderScore { get; set; }

    [JsonProperty ("defending_faction")]
    public required int DefenderFaction { get; set; }

    [JsonProperty ("raider_score")]
    public required string RaiderScore { get; set; }

    [JsonProperty ("raiding_faction")]
    public required int RaiderFaction { get; set; }

    [JsonProperty ("start_time")]
    public required long StartTime { get; set; }
}
