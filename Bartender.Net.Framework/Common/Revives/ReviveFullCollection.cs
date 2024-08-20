using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class ReviveFullCollection {
    [JsonProperty ("revives")]
    public required Dictionary<string, ReviveFull> Revives { get; set; }
}
