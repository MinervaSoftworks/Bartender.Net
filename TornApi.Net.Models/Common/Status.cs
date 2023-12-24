using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class Status {
    public int ID { get; set; }

    public int OwnerID { get; set; }

    [JsonProperty("color")]
    public StatusColor Color { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("details")]
    public string Details { get; set; }

    [JsonProperty("state")]
    public StatusState State { get; set; }

    [JsonProperty("until")]
    public long Until { get; set; }
}
