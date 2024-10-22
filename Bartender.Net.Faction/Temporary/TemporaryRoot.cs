﻿using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Temporary;

public class TemporaryRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("temporary")]
    public virtual required List<FactionLoanable> Loanables { get; set; }
}
