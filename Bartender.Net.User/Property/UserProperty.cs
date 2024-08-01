using Bartender.Net.Framework.Common.Property;
using Bartender.Net.Framework.User.Property;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class UserProperty : IUserProperty {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("owner_id")]
    public int OwnerId { get; set; }

    [JsonProperty ("property_type")]
    public int PropertyType { get; set; }

    [JsonProperty ("property")]
    public string PropertyName { get; set; }

    [JsonProperty ("status")]
    public string Status { get; set; }

    [JsonProperty ("happy")]
    public int Happy { get; set; }

    [JsonProperty ("upkeep")]
    public int Upkeep { get; set; }

    [JsonProperty ("staff_cost")]
    public int StaffCost { get; set; }

    [JsonProperty ("cost")]
    public int Cost { get; set; }

    [JsonProperty ("marketprice")]
    public int MarketPrice { get; set; }

    [JsonProperty ("modifications")]
    public IPropertyModifications Modifications { get; set; }

    [JsonProperty ("staff")]
    public IPropertyStaff Staff { get; set; }

    [JsonProperty ("rented")]
    public IRentEntry Rented { get; set; }
}
