using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Torn.ChainReport;

public class TornChainReport {
    [JsonProperty ("assists")]
    public required int Assists { get; set; }

    [JsonProperty ("besthit")]
    public required int BestHit { get; set; }

    [JsonProperty ("bonuses")]
    public required List<ChainBonus> Bonuses { get; set; }

    [JsonProperty ("draws")]
    public required int Draws { get; set; }

    [JsonProperty ("end")]
    public long End { get; set; }

    [JsonProperty ("escapes")]
    public required int Escapes { get; set; }

    [JsonProperty ("factionID")]
    public required int FactionID { get; set; }

    [JsonProperty ("leave")]
    public required int Leave { get; set; }

    [JsonProperty ("losses")]
    public required int Losses { get; set; }

    [JsonProperty ("mug")]
    public required int Mug { get; set; }

    [JsonProperty ("overseas")]
    public required int Overseas { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("retaliations")]
    public required int Retaliations { get; set; }

    [JsonProperty ("start")]
    public long Start { get; set; }

    [JsonProperty ("targets")]
    public required int Targets { get; set; }

    [JsonProperty ("warhits")]
    public required int WarHits { get; set; }

    [JsonProperty ("members")]
    [NotMapped]
    public Dictionary<string, ChainMember> Members { get; set; } = default!;

    public virtual List<ChainMember> MembersList {
        get => Members.TornDictionaryToList ();
        set => Members = value.ToTornDictionary ();
    }
}
