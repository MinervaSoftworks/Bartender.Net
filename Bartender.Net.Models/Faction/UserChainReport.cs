using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class UserChainReport {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("userID")]
    public int UserID { get; set; }

    [JsonProperty ("factionID")]
    public int FactionID { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("attacks")]
    public int Attacks { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("avg")]
    public double Avg { get; set; }

    [JsonProperty ("leave")]
    public int Leave { get; set; }

    [JsonProperty ("mug")]
    public int Mug { get; set; }

    [JsonProperty ("hosp")]
    public int Hosp { get; set; }

    [JsonProperty ("war")]
    public int War { get; set; }

    [JsonProperty ("bonus")]
    public int Bonus { get; set; }

    [JsonProperty ("assist")]
    public int Assist { get; set; }

    [JsonProperty ("retal")]
    public int Retal { get; set; }

    [JsonProperty ("overseas")]
    public int Overseas { get; set; }

    [JsonProperty ("draw")]
    public int Draw { get; set; }

    [JsonProperty ("escape")]
    public int Escape { get; set; }

    [JsonProperty ("loss")]
    public int Loss { get; set; }

    [JsonProperty ("best")]
    public double Best { get; set; }
}
