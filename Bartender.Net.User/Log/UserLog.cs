using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class UserLog {
    [JsonProperty ("log")]
    public Dictionary<int, LogEntry> Entries { get; set; }
}
