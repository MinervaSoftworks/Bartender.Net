using Newtonsoft.Json;

namespace Bartender.Net.User.DisplayCase;

public class DisplayCaseRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("display")]
    public required List<DisplayCaseItem> Items { get; set; }
}
