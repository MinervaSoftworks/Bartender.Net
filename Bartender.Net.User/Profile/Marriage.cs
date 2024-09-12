using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Marriage : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("duration")]
    public required int Duration { get; set; }

    [JsonProperty ("spouse_id")]
    public required int SpouseID { get; set; }

    [JsonProperty ("spouse_name")]
    public required string SpouseName { get; set; }
}
