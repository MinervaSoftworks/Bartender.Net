using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Honors;

public class HonorsRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("honors_awarded")]
    public required List<int> HonorsAwarded { get; set; }

    [JsonProperty ("honors_time")]
    public required List<int> HonorsTime { get; set; }
}

