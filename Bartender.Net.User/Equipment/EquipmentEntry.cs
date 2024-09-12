using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Equipment;

public class EquipmentEntry : IBartenderEntity {
    [JsonProperty ("ID")]
    public int ID { get; set; }

    [JsonProperty ("equipped")]
    public required int Equiped { get; set; }

    [JsonProperty ("market_price")]
    public required int MarketPrice { get; set; }

    [JsonProperty ("name")]
    public required string Name { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("type")]
    public required string Type { get; set; }

    [JsonProperty ("UID")]
    public required int UID { get; set; }
}
