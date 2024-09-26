using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Revives;
using Newtonsoft.Json;

namespace Bartender.Net.User.Revives;

public class UserRevivesRoot {
    [JsonProperty ("revives")]
    public required List<Revive> Revives { get; set; }
}
