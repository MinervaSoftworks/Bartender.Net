using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.ChainReport;

public class ChainParticipant : BartenderEntity {
    [JsonProperty ("userID")]    public required int ChainPerticipantID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("factionID")]
    public required int FactionID { get; set; }

    [JsonProperty ("level")]
    public required int Level { get; set; }

    [JsonProperty ("attacks")]
    public required int Attacks { get; set; }

    [JsonProperty ("respect")]
    public required int Respect { get; set; }

    [JsonProperty ("avg")]
    public required int Avg { get; set; }

    [JsonProperty ("leave")]
    public required int Leave { get; set; }

    [JsonProperty ("mug")]
    public required int Mug { get; set; }

    [JsonProperty ("hosp")]
    public required int Hosp { get; set; }

    [JsonProperty ("war")]
    public required int War { get; set; }

    [JsonProperty ("bonus")]
    public required int Bonus { get; set; }

    [JsonProperty ("assist")]
    public required int Assist { get; set; }

    [JsonProperty ("retal")]
    public required int Retal { get; set; }

    [JsonProperty ("overseas")]
    public required int Overseas { get; set; }

    [JsonProperty ("draw")]
    public required int Draw { get; set; }

    [JsonProperty ("escape")]
    public required int Escape { get; set; }

    [JsonProperty ("loss")]
    public required int Loss { get; set; }

    [JsonProperty ("best")]
    public required int Best { get; set; }
}
