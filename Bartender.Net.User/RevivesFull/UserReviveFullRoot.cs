using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.RevivesFull;
using Newtonsoft.Json;

namespace Bartender.Net.User.RevivesFull;

public class UserReviveFullRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("revives")]
    public required Dictionary<string, ReviveFull> Revives { get; set; }
}
