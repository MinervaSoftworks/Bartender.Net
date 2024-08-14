using Newtonsoft.Json;

namespace Bartender.Net.Company.News;

public class CompanyNewsEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("news")]
    public required string News { get; set; }

    [JsonProperty ("timestamp")]
    public required int Timestamp { get; set; }
}
