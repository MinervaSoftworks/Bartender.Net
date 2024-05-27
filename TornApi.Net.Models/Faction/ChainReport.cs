using Newtonsoft.Json;

namespace TornApi.Net.Models.Faction;

public class ChainReport {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("factionID")]
    public int FactionID { get; set; }

    [JsonProperty ("chain")]
    public int Chain { get; set; }

    [JsonProperty ("start")]
    public int Start { get; set; }

    [JsonProperty ("end")]
    public int End { get; set; }

    [JsonProperty ("leave")]
    public int Leave { get; set; }

    [JsonProperty ("mug")]
    public int Mug { get; set; }

    [JsonProperty ("hospitalize")]
    public int Hospitalize { get; set; }

    [JsonProperty ("assists")]
    public int Assists { get; set; }

    [JsonProperty ("overseas")]
    public int Overseas { get; set; }

    [JsonProperty ("draws")]
    public int Draws { get; set; }

    [JsonProperty ("escapes")]
    public int Escapes { get; set; }

    [JsonProperty ("losses")]
    public int Losses { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("targets")]
    public int Targets { get; set; }

    [JsonProperty ("warhits")]
    public int Warhits { get; set; }

    [JsonProperty ("besthit")]
    public int Besthit { get; set; }

    [JsonProperty ("retaliations")]
    public int Retaliations { get; set; }

    [JsonProperty ("members")]
    public IDictionary<string, UserChainReport> Members { get; set; }

    [JsonProperty ("bonuses")]
    public IEnumerable<Bonus> Bonuses { get; set; }
}
