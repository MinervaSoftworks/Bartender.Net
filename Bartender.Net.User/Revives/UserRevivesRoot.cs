﻿using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class UserRevivesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("revives")]
    public virtual required List<Revive> Revives { get; set; }
}
