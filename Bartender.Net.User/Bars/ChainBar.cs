using Bartender.Net.Framework.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class ChainBar : IChainBar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cooldown")]
    public int Cooldown { get; set; }

    [JsonProperty ("currnet")]
    public int Current { get; set; }

    [JsonProperty ("maximum")]
    public int Maximum { get; set; }

    [JsonProperty ("modifier")]
    public float Modifier { get; set; }

    [JsonProperty ("timeout")]
    public int Timeout { get; set; }
}
