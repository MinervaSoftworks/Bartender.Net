using Newtonsoft.Json;

namespace Bartender.Net.Common.Reports;

public class FriendOrFoeUser {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("user_id")]
    public int UserID { get; set; }
}

