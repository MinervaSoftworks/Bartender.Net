using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Honors;

public class HonorsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("honors_awarded")]
    public virtual required List<int> HonorsAwarded { get; set; }

    [JsonProperty ("honors_time")]
    public virtual required List<int> HonorsTime { get; set; }
}

