using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.DisplayCase;

public class DisplayCaseRoot {
    [JsonProperty ("display")]
    public required List<DisplayCaseItem> Items { get; set; }
}
