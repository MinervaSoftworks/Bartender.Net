using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class Bar {
    [JsonProperty("current")]
    public int Current { get; set; }

    [JsonProperty("fulltime")]
    public int Fulltime { get; set; }

    [JsonProperty("increment")]
    public int Increment { get; set; }

    [JsonProperty("interval")]
    public int Interval { get; set; }

    [JsonProperty("Maximum")]
    public int Maximum { get; set; }

    [JsonProperty("ticktime")]
    public int Ticktime { get; set; }
}
