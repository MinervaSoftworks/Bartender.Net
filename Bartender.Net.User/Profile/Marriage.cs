using Bartender.Net.Framework.User.Profile;
using Newtonsoft.Json;

namespace Bartender.Net.User.Profile;

public class Marriage : IMarriage {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("duration")]
    public int Duration { get; set; }

    [JsonProperty ("spouse_id")]
    public int SpouseID { get; set; }

    [JsonProperty ("spouse_name")]
    public string SpouseName { get; set; }
}
