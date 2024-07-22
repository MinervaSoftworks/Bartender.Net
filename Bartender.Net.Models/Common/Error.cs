using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class Error {
    [JsonProperty ("code")]
    public int Code { get; set; } = -1;

    [JsonProperty ("error")]
    public string ErrorMsg { get; set; }
}
