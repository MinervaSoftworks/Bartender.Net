using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class UserBazaar {
    [JsonProperty("bazaar")]
    public List<Bazaar> Bazaars { get; set; }
}
