using Newtonsoft.Json;

namespace Bartender.Net.Framework;

public class Error {
    [JsonProperty ("code")]
    public int Code { get; set; } = -1;

    [JsonProperty ("error")]
    public string ErrorMsg { get; set; }
}
