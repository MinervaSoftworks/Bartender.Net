using Newtonsoft.Json;

namespace Bartender.Net.User.Networth;

public class NetworthRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("Networth")]
    public required NetworthRecord NetworthRecord { get; set; }
}