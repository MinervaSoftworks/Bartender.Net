using Bartender.Net.Framework.Common.User;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class UserProperty {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("owner_id")]
    public required int OwnerId { get; set; }

    [JsonProperty ("property_type")]
    public required int PropertyType { get; set; }

    [JsonProperty ("property")]
    public required string PropertyName { get; set; }

    [JsonProperty ("status")]
    public required string Status { get; set; }

    [JsonProperty ("happy")]
    public required int Happy { get; set; }

    [JsonProperty ("upkeep")]
    public required int Upkeep { get; set; }

    [JsonProperty ("staff_cost")]
    public required int StaffCost { get; set; }

    [JsonProperty ("cost")]
    public required int Cost { get; set; }

    [JsonProperty ("marketprice")]
    public required int MarketPrice { get; set; }

    [JsonProperty ("modifications")]
    public required PropertyModifications Modifications { get; set; }

    [JsonProperty ("staff")]
    public required PropertyStaff Staff { get; set; }

    [JsonProperty ("rented")]
    public required RentEntry Rented { get; set; }
}
