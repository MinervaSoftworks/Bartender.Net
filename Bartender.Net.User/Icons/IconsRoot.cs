using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Icons;

public class IconsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("icons")]
    public required Dictionary<string, string> Icons { get; set; }
}