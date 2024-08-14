using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class ReviveCollection {
    [JsonProperty ("revives")]
    public Dictionary<string, Revive> Revives { get; set; }
}
