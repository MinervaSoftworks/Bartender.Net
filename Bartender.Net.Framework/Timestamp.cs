using Newtonsoft.Json;

namespace Bartender.Net.Framework;

public class Timestamp {
    [JsonProperty ("timestamp")]
    public int Value { get; set; }
}
