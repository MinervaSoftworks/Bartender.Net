﻿using Bartender.Net.Framework.User.Messages;
using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class UserMessageCollection : IUserMessageCollection {
    [JsonProperty ("messages")]
    public required IDictionary<string, IUserMessage> Messages { get; set; }
}