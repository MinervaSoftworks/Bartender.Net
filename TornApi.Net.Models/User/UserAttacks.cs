using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class UserAttacks {
    [JsonProperty("attacks")]
    public IDictionary<string, Attack> Attacks { get; set; }
}

