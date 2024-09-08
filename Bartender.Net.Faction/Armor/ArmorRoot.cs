﻿using Bartender.Net.Faction.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class ArmorRoot {
    [JsonProperty ("armor")]
    public required List<FactionLoanable> Loanables { get; set; }
}