using Bartender.Net.Framework.User.Equipment;
using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class UserEquipment : IUserEquipment {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("equipped")]
    public int Equiped { get; set; }

    [JsonProperty ("market_price")]
    public int MarketPrice { get; set; }

    [JsonProperty ("name")]
    public string Name { get; set; }

    [JsonProperty ("quantity")]
    public int Quantity { get; set; }

    [JsonProperty ("type")]
    public string Type { get; set; }

    [JsonProperty ("UID")]
    public int UID { get; set; }
}
