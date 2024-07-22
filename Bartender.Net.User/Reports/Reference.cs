using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class Reference {
    [JsonProperty("ID")]
    public required int ID { get; set; }

    [JsonProperty("joined")]
    public required string Joined { get; set; }

    [JsonProperty("left")]
    public required string Left { get; set; }

    [JsonProperty("name")]
    public required string Name { get; set; }
}
