using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Revives;

public class ReviveCollection {
    [JsonProperty ("revives")]
    public required Dictionary<string, Revive> Revives { get; set; }
}
