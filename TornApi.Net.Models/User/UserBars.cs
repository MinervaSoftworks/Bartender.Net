using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class UserBars {
    [JsonProperty ("chain")]
    public ChainBar Chain { get; set; }

    [JsonProperty ("energy")]
    public Bar Energy { get; set; }

    [JsonProperty ("happy")]
    public Bar Happy { get; set; }

    [JsonProperty ("life")]
    public Bar Life { get; set; }

    [JsonProperty ("nerve")]
    public Bar Nerve { get; set; }

    [JsonProperty ("server_time")]
    public int ServerTime { get; set; }
}
