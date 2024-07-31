using Newtonsoft.Json;

namespace Bartender.Net.Company.Detailed;

public class CompanyUpgrades : ICompanyUpgrades {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("company_size")]
    public int CompanySize { get; set; }

    [JsonProperty ("staffroom_size")]
    public string StaffroomSize { get; set; }

    [JsonProperty ("storage_room")]
    public string StorageSize { get; set; }

    [JsonProperty ("storage_space")]
    public int StorageSpace { get; set; }
}
