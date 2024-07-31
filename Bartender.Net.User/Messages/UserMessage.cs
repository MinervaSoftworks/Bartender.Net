using Bartender.Net.Framework.User.Messages;
using Newtonsoft.Json;

namespace Bartender.Net.User.Messages;

public class UserMessage : IUserMessage {
    [JsonProperty ("timestamp")]
    public int Timestamp { get; set; }

    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("title")]
    public string Title { get; set; }

    [JsonProperty ("seen")]
    public int Seen { get; set; }

    [JsonProperty ("read")]
    public int Read { get; set; }
}
