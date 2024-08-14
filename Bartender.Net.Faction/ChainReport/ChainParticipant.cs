using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class ChainParticipant {
    [JsonProperty ("userID")]
    public int ID { get; set; }

    [JsonProperty ("factionID")]
    public int FactionID { get; set; }

    [JsonProperty ("level")]
    public int Level { get; set; }

    [JsonProperty ("attacks")]
    public int Attacks { get; set; }

    [JsonProperty ("respect")]
    public int Respect { get; set; }

    [JsonProperty ("avg")]
    public int Avg { get; set; }

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
    public int Best { get; set; }
}
