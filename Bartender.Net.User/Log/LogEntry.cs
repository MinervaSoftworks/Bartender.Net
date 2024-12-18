using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Log;

public class LogEntry : BartenderEntity {
    [JsonProperty ("category")]
    public required string Category { get; set; }

    [JsonProperty ("data")]
    [NotMapped]
    public Dictionary<string, int> Data { get; set; } = default!;

    [JsonProperty ("log")]
    public required string LogType { get; set; }

    [JsonProperty ("params")]
    [NotMapped]
    public Dictionary<string, string> Params { get; set; } = default!;

    [JsonProperty ("timestamp")]
    public long Timestamp { get; set; }

    [JsonProperty ("title")]
    public required string Title { get; set; }
}
