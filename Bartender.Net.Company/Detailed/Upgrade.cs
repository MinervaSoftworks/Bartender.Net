using Newtonsoft.Json;

namespace Bartender.Net.Company.Detailed;

public class Upgrade {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company_size")]
    public required int CompanySize { get; set; }

    [JsonProperty ("staffroom_size")]
    public required string StaffroomSize { get; set; }

    [JsonProperty ("storage_room")]
    public required string StorageSize { get; set; }

    [JsonProperty ("storage_space")]
    public required int StorageSpace { get; set; }
}
