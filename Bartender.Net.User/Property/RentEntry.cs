using Bartender.Net.Framework.Common.Property;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class RentEntry : IRentEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("cost_per_day")]
    public int CostPerDay { get; set; }

    [JsonProperty ("days_left")]
    public int DaysLeft { get; set; }

    [JsonProperty ("total_cost")]
    public int TotalCost { get; set; }

    [JsonProperty ("user_id")]
    public int UserID { get; set; }
}
