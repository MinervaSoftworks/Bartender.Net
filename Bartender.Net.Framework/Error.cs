using Newtonsoft.Json;

namespace Bartender.Net.Framework;

public class Error {
    [JsonProperty ("code")]
    public required int Code { get; set; } = -1;

    [JsonProperty ("error")]
    public required string ErrorMsg { get; set; }
}
