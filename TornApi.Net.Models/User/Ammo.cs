using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Ammo {
    [JsonProperty ("ammoID")]
    public int AmmoID { get; set; }

    [JsonProperty ("equipped")]
    public bool Equipped { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("size")]
    public string Size { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("typeID")]
    public int TypeID { get; set; }
}

