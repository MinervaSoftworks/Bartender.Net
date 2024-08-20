using Bartender.Net.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.Property;

public class PropertyEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("owner_id")]
    public required int OwnerId { get; set; }

    [JsonProperty ("property_type")]
    public required int PropertyType { get; set; }

    [JsonProperty ("happy")]
    public required int Happy { get; set; }

    [JsonProperty ("upkeep")]
    public required int Upkeep { get; set; }

    [JsonProperty ("upgrades")]
    public required List<string> Upgrades { get; set; }

    [JsonProperty ("staff")]
    public required List<string> Staff { get; set; }

    [JsonProperty ("rented")]
    public required RentEntry Rented { get; set; }

    [JsonProperty ("users_living")]
    public required string UsersLiving { get; set; }
}
