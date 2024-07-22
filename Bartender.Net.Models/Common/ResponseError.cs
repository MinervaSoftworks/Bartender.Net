using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class ResponseError {
    [JsonProperty ("error")]
    public Error Error { get; set; }
}
