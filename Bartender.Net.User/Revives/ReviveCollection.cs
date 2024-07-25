using Bartender.Net.Framework.User.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class ReviveCollection : IReviveCollection {
    [JsonProperty("revives")]
    public required IDictionary<string, IRevive> Revives { get; set; }
}
