using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Status {
    public int StatusID { get; set; }

    [JsonProperty ("color")]
    public StatusColor Color { get; set; }

    [JsonProperty ("description")]
    public string Description { get; set; }

    [JsonProperty ("details")]
    public string Details { get; set; }

    [JsonProperty ("state")]
    public StatusState State { get; set; }

    [JsonProperty ("until")]
    public long Until { get; set; }
}
