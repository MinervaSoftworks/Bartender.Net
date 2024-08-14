using Newtonsoft.Json;

namespace Bartender.Net.Framework;

public class ResponseError {
    [JsonProperty ("error")]
    public required Error Error { get; set; }
}
