using Bartender.Net.Framework.User.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class ReviveFullCollection : IReviveFullCollection {
    [JsonProperty ("revives")]
    public required IDictionary<string, IReviveFull> Revives { get; set; }
}
