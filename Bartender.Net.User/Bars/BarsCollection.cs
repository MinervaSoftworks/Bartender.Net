using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class BarsCollection {
    [JsonProperty ("server_time")]
    public int ServerTime { get; set; }

    [JsonProperty ("happy")]
    public Bar Happy { get; set; }

    [JsonProperty ("life")]
    public Bar Life { get; set; }

    [JsonProperty ("energy")]
    public Bar Energy { get; set; }

    [JsonProperty ("nerve")]
    public Bar Nerve { get; set; }

    [JsonProperty ("chain")]
    public Bar Chain { get; set; }
}
