using Newtonsoft.Json;

namespace Bartender.Net.User.WeaponExp;

public class WeaponExpEntry {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("itemID")]
    public required int ItemID { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("exp")]
    public required int Exp { get; set; }
}
