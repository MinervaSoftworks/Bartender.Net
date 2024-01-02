﻿using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class LastAction {
    public int LastActionID { get; set; }

    [JsonProperty ("relative")]
    public string Relative { get; set; }

    [JsonProperty ("status")]
    public LastActionStatus Status { get; set; }

    [JsonProperty ("timestamp")]
    public long? Timestamp { get; set; }
}
