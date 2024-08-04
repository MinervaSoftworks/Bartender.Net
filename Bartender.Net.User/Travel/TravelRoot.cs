using Bartender.Net.Framework;
using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.Travel;
using Bartender.Net.User.WeaponExp;
using Newtonsoft.Json;

namespace Bartender.Net.User.Travel;

public class TravelRoot : ITravelRoot, ISelectionRoot {
    [JsonProperty ("travel")]
    [JsonConverter (typeof (ConcreteConverter<TravelEntry>))]
    public required ITravelEntry Travel { get; set; }

    public AccessLevel AccessLevelRequired => AccessLevel.Minimal;

    public string EndpointString => "travel";

    public string Name => "Travel";
}
