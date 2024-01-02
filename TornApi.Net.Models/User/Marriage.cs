using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Marriage {
    public int MarriageID { get; set; }

    [JsonProperty ("duration")]
    public int Duration { get; set; }

    [JsonProperty ("spouse_id")]
    public int SpouseID { get; set; }

    [JsonProperty ("spouse_name")]
    public string SpouseName { get; set; }
}
