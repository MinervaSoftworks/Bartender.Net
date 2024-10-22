﻿using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Weapons;

public class WeaponsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("weapons")]
    public virtual required List<FactionLoanable> Loanables { get; set; }
}
