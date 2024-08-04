using Newtonsoft.Json;

namespace Bartender.Net.Framework;

public class ResponseError {
    [JsonProperty ("error")]
    public Error Error { get; set; }
}
