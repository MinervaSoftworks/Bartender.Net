using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class ReviveCollection : IReviveCollection {
    [JsonProperty ("revives")]
    public IDictionary<string, IRevive> Revives { get; set; }
}
