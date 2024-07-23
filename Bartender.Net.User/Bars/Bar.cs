using Bartender.Net.Framework.User.Bars;
using Newtonsoft.Json;

namespace Bartender.Net.User.Bars;

public class Bar : IBar {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("current")]
    public required int Current { get; set; }

    [JsonProperty ("fulltime")]
    public required int Fulltime { get; set; }

    [JsonProperty ("increment")]
    public required int Increment { get; set; }

    [JsonProperty ("interval")]
    public required int Interval { get; set; }

    [JsonProperty ("maximum")]
    public required int Maximum { get; set; }

    [JsonProperty ("ticktime")]
    public required int Ticktime { get; set; }
}
