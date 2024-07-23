﻿using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class Message {
    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }

    [JsonProperty ("ID")]
    public required int ID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }

    [JsonProperty ("seen")]
    public required int Seen { get; set; }

    [JsonProperty ("read")]
    public required int Read { get; set; }
}