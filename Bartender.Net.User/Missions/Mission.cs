﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Missions;

public class Mission {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }
}