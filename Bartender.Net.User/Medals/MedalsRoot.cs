using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Medals;

public class MedalsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("medals_awarded")]
    public virtual required List<int> MedalsAwarded { get; set; }

    [JsonProperty ("medals_time")]
    public virtual required List<int> MedalsTime { get; set; }
}