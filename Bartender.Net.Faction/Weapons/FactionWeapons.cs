﻿using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionWeapons {
    [JsonProperty ("weapons")]
    public List<FactionLoanable> Loanables { get; set; }
}
