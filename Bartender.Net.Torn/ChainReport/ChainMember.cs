using Newtonsoft.Json;

namespace Bartender.Net.Torn.ChainReport;

public class ChainMember {
    [JsonIgnore]

    [JsonProperty ("assist")]
    public required int Assist { get; set; }

    [JsonProperty ("attacks")]
    public required int Attacks { get; set; }

    [JsonProperty ("avg")]
    public double Avg { get; set; }

    [JsonProperty ("best")]
    public double Best { get; set; }

    [JsonProperty ("bonus")]
    public required int Bonus { get; set; }

    [JsonProperty ("escape")]
    public required int Escape { get; set; }

    [JsonProperty ("factionID")]
    public required int FactionID { get; set; }

    [JsonProperty ("hosp")]
    public required int Hosp { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("leave")]
    public required int Leave { get; set; }

    [JsonProperty ("loss")]
    public required int Loss { get; set; }

    [JsonProperty ("mug")]
    public required int Mug { get; set; }

    [JsonProperty ("overseas")]
    public required int Overseas { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("retal")]
    public required int Retal { get; set; }

    [JsonProperty ("war")]
    public required int War { get; set; }

    [JsonProperty ("userID")]
    public required int UserID { get; set; }
}
