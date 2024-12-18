using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogRoot : BartenderEntity {
    [JsonProperty ("log")]
    public required Dictionary<int, LogEntry> Entries { get; set; }
}
