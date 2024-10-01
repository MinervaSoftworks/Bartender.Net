using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class LogRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("log")]
    public required Dictionary<int, LogEntry> Entries { get; set; }
}
