using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Refills;

public class RefillsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("refills")]
    public virtual required RefillStates Refills { get; set; }
}
