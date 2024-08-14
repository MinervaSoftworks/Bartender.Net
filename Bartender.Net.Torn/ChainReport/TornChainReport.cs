using Newtonsoft.Json;

namespace Bartender.Net.Torn.ChainReport;

public class TornChainReport {
    [JsonProperty ("assists")]
    public int Assists { get; set; }

    [JsonProperty ("besthit")]
    public int BestHit { get; set; }

    [JsonProperty ("bonuses")]
    public List<ChainBonus> Bonuses { get; set; }

    [JsonProperty ("draws")]
    public int Draws { get; set; }

    [JsonProperty ("end")]
    public long End { get; set; }

    [JsonProperty ("escapes")]
    public int Escapes { get; set; }

    [JsonProperty ("factionID")]
    public int FactionID { get; set; }

    [JsonProperty ("leave")]
    public int Leave { get; set; }

    [JsonProperty ("losses")]
    public int Losses { get; set; }

    [JsonProperty ("mug")]
    public int Mug { get; set; }

    [JsonProperty ("overseas")]
    public int Overseas { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("retaliations")]
    public int Retaliations { get; set; }

    [JsonProperty ("start")]
    public long Start { get; set; }

    [JsonProperty ("targets")]
    public int Targets { get; set; }

    [JsonProperty ("warhits")]
    public int WarHits { get; set; }

    [JsonProperty ("members")]
    public Dictionary<string, ChainMember> Members { get; set; }
}
