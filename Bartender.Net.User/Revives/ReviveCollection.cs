using Bartender.Net.Framework.User.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class ReviveCollection : IReviveCollection {
    [JsonProperty ("revives")]
    public IDictionary<string, IRevive> Revives { get; set; }
}
