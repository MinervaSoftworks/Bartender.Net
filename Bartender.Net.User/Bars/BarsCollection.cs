using Bartender.Net.Framework.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class BarsCollection : IBarsCollection {
    [JsonProperty ("server_time")]
    public required int ServerTime { get; set; }

    [JsonProperty ("happy")]
    public required IBar Happy { get; set; }

    [JsonProperty ("life")]
    public required IBar Life { get; set; }

    [JsonProperty ("energy")]
    public required IBar Energy { get; set; }

    [JsonProperty ("nerve")]
    public required IBar Nerve { get; set; }

    [JsonProperty ("chain")]
    public required IBar Chain { get; set; }
}
