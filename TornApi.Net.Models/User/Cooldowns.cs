using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Cooldowns {
    [JsonProperty("drug")]
    public int Drug { get; set; }

    [JsonProperty("medical")]
    public int Medical { get; set; }

    [JsonProperty("booster")]
    public int Booster { get; set; }
}

public class Discord {
    [JsonProperty("userID")]
    public int UserID { get; set; }

    [JsonProperty("discordID")]
    public string DiscordID { get; set; }
}
