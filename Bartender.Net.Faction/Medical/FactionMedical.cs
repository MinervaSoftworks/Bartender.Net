﻿using Bartender.Net.Framework.Faction.Common;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Boosters;

public class FactionMedical : IFactionArmoryItems {
    [JsonProperty ("medical")]
    public IEnumerable<IFactionArmoryItem> Items { get; set; }
}