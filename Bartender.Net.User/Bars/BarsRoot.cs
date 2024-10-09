using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class BarsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("server_time")]
    public required int ServerTime { get; set; }

    [JsonProperty ("happy")]
    public virtual required Bar Happy { get; set; }

    [JsonProperty ("life")]
    public virtual required Bar Life { get; set; }

    [JsonProperty ("energy")]
    public virtual required Bar Energy { get; set; }

    [JsonProperty ("nerve")]
    public virtual required Bar Nerve { get; set; }

    [JsonProperty ("chain")]
    public virtual required ChainBar Chain { get; set; }
}
