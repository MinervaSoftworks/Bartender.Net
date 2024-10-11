using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("log")]
    public required Dictionary<int, LogEntry> Entries { get; set; }
}
