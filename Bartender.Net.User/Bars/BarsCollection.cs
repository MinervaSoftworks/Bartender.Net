using Bartender.Net.Framework.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class BarsCollection : IBarsCollection {
    [JsonProperty ("server_time")]
    public int ServerTime { get; set; }

    [JsonProperty ("happy")]
    public IBar Happy { get; set; }

    [JsonProperty ("life")]
    public IBar Life { get; set; }

    [JsonProperty ("energy")]
    public IBar Energy { get; set; }

    [JsonProperty ("nerve")]
    public IBar Nerve { get; set; }

    [JsonProperty ("chain")]
    public IBar Chain { get; set; }
}
