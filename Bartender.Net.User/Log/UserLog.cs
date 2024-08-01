using Bartender.Net.Framework.User.Log;
using Newtonsoft.Json;

namespace Bartender.Net.User.Log;

public class UserLog : IUserLog {
    [JsonProperty ("log")]
    public IDictionary<int, ILogEntry> Entries { get; set; }
}
