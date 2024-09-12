using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Property;

public class PropertyModifications : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("interior")]
    public required int Interior { get; set; }

    [JsonProperty ("hot_tub")]
    public required int HotTub { get; set; }

    [JsonProperty ("sauna")]
    public required int Sauna { get; set; }

    [JsonProperty ("pool")]
    public required int Pool { get; set; }

    [JsonProperty ("open_bar")]
    public required int OpenBar { get; set; }

    [JsonProperty ("shooting_range")]
    public required int ShootingRange { get; set; }

    [JsonProperty ("vault")]
    public required int Vault { get; set; }

    [JsonProperty ("medical_facility")]
    public required int MedicalFacility { get; set; }

    [JsonProperty ("airstrip")]
    public required int Airstrip { get; set; }

    [JsonProperty ("yacht")]
    public required int Yacht { get; set; }
}
