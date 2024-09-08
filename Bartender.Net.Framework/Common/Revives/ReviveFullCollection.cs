using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Revives;

public class ReviveFullCollection {
    [JsonProperty ("revives")]
    public required Dictionary<string, ReviveFull> Revives { get; set; }
}
