using Bartender.Net.Framework.User.Merits;
using Newtonsoft.Json;

namespace Bartender.Net.User.Merits;

public class MeritCollection : IMeritCollection {
    [JsonProperty ("merits")]
    public IUserMerits Merits { get; set; }
}
