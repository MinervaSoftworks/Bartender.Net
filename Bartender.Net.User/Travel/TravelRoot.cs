using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.Travel;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelRoot : ITravelRoot {
    [JsonProperty ("travel")]
    [JsonConverter (typeof (ConcreteConverter<TravelEntry>))]
    public required ITravelEntry Travel { get; set; }
}
