using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class Position {
    [JsonProperty ("description")]
    public required string Description { get; set; }

    [JsonProperty ("end_gain")]
    public required int EndGain { get; set; }

    [JsonProperty ("end_required")]
    public required int EndRequired { get; set; }

    [JsonProperty ("int_gain")]
    public required int IntGain { get; set; }

    [JsonProperty ("int_required")]
    public required int IntRequired { get; set; }

    [JsonProperty ("man_gain")]
    public required int ManGain { get; set; }

    [JsonProperty ("man_required")]
    public required int ManRequired { get; set; }

    [JsonProperty ("special_ability")]
    public required PositionSpecialAbility SpecialAbility { get; set; }
}
