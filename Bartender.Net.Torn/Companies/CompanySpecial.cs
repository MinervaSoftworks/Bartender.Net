using Newtonsoft.Json;

namespace Bartender.Net.Torn.CityShops;

public class CompanySpecial {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("effect")]
    public required string Effect { get; set; }

    [JsonProperty ("rating_required")]
    public required int RatingRequired { get; set; }
}
