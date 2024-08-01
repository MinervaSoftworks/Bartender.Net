using Bartender.Net.Framework.User.Refills;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class UserRefills : IUserRefills {
    [JsonProperty ("refills")]
    public IRefillStates Refills { get; set; }
}
