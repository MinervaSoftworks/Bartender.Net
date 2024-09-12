using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class BarsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("server_time")]
    public required int ServerTime { get; set; }

    [JsonProperty ("happy")]
    public required Bar Happy { get; set; }

    [JsonProperty ("life")]
    public required Bar Life { get; set; }

    [JsonProperty ("energy")]
    public required Bar Energy { get; set; }

    [JsonProperty ("nerve")]
    public required Bar Nerve { get; set; }

    [JsonProperty ("chain")]
    public required ChainBar Chain { get; set; }
}
