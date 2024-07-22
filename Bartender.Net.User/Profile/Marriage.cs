using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Marriage {
    [JsonIgnore]
    public required int ID { get; set; }

    [JsonProperty ("duration")]
    public required int Duration { get; set; }

    [JsonProperty ("spouse_id")]
    public required int SpouseID { get; set; }

    [JsonProperty ("spouse_name")]
    public required string SpouseName { get; set; }
}
