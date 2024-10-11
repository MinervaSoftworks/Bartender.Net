using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.DisplayCase;

public class DisplayCaseRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("display")]
    public virtual required List<DisplayCaseItem> Items { get; set; }
}
