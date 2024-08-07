using Bartender.Net.Framework.Common.Property;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class RentEntry : IRentEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cost_per_day")]
    public required int CostPerDay { get; set; }

    [JsonProperty ("days_left")]
    public required int DaysLeft { get; set; }

    [JsonProperty ("total_cost")]
    public required int TotalCost { get; set; }

    [JsonProperty ("user_id")]
    public required int UserID { get; set; }
}
