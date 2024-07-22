using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Status
{
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty("color")]
    public required StatusColor Color { get; set; }

    [JsonProperty("description")]
    public required string Description { get; set; }

    [JsonProperty("details")]
    public required string Details { get; set; }

    [JsonProperty("state")]
    public required StatusState State { get; set; }

    [JsonProperty("until")]
    public required long Until { get; set; }
}

