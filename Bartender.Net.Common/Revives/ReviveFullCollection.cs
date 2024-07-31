using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.Common.Revives;

public class ReviveFullCollection : IReviveFullCollection {
    [JsonProperty ("revives")]
    public IDictionary<string, IReviveFull> Revives { get; set; }
}
