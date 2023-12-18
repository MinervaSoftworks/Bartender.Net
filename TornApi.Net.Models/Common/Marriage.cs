using Newtonsoft.Json;

namespace TornApi.Net.Models.Common;

public class Marriage {
    [JsonProperty("duration")]
    public int Duration { get; set; }

    [JsonProperty("spouse_id")]
    public int SpouseID { get; set; }

    [JsonProperty("spouse_name")]
    public string SpouseName { get; set; }
}
