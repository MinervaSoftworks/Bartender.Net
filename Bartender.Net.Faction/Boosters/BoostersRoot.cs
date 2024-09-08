﻿using Bartender.Net.Faction.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class BoostersRoot {
    [JsonProperty ("boosters")]
    public required List<FactionArmoryItem> Items { get; set; }
}