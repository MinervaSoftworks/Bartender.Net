﻿using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.NewEvents;

public class NewUserEventsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("events")]
    public required Dictionary<string, NewUserEvent> Events { get; set; }

    [JsonProperty ("player_id")]
    public required int PlayerID { get; set; }
}
