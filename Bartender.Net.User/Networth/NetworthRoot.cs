using Newtonsoft.Json;

namespace Bartender.Net.User.Networth;

public class NetworthRoot {
    [JsonProperty ("Networth")]
    public required NetworthRecord NetworthRecord { get; set; }
}