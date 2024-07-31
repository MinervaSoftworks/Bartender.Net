using Bartender.Net.Framework.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class Bar : IBar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("current")]
    public int Current { get; set; }

    [JsonProperty ("fulltime")]
    public int Fulltime { get; set; }

    [JsonProperty ("increment")]
    public int Increment { get; set; }

    [JsonProperty ("interval")]
    public int Interval { get; set; }

    [JsonProperty ("maximum")]
    public int Maximum { get; set; }

    [JsonProperty ("ticktime")]
    public int Ticktime { get; set; }
}
