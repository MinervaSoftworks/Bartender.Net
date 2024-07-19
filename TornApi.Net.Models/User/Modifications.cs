using Newtonsoft.Json;

namespace TornApi.Net.Models.User;

public class Modifications {
    [JsonProperty("interior")]
    public int Interior { get; set; }

    [JsonProperty("hot_tub")]
    public int HotTub { get; set; }

    [JsonProperty("sauna")]
    public int Sauna { get; set; }

    [JsonProperty("pool")]
    public int Pool { get; set; }

    [JsonProperty("open_bar")]
    public int OpenBar { get; set; }

    [JsonProperty("shooting_range")]
    public int ShootingRange { get; set; }

    [JsonProperty("vault")]
    public int Vault { get; set; }

    [JsonProperty("medical_facility")]
    public int MedicalFacility { get; set; }

    [JsonProperty("airstrip")]
    public int Airstrip { get; set; }

    [JsonProperty("yacht")]
    public int Yacht { get; set; }
}
