using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.ChainReport;

public class FactionChainReport : BartenderEntity {
    [JsonProperty ("userID")]    public required int FactionChainReportID {
        get => TornID;
        set => TornID = value;
    }

    [JsonProperty ("factionID")]
    public required int FactionID { get; set; }

    [JsonProperty ("chain")]
    public required int Chain { get; set; }

    [JsonProperty ("start")]
    public required int Start { get; set; }

    [JsonProperty ("end")]
    public required int End { get; set; }

    [JsonProperty ("leave")]
    public required int Leave { get; set; }

    [JsonProperty ("mug")]
    public required int Mug { get; set; }

    [JsonProperty ("hospitalize")]
    public required int Hospitalize { get; set; }

    [JsonProperty ("assists")]
    public required int Assists { get; set; }

    [JsonProperty ("overseas")]
    public required int Overseas { get; set; }

    [JsonProperty ("draws")]
    public required int Draws { get; set; }

    [JsonProperty ("escapes")]
    public required int Escapes { get; set; }

    [JsonProperty ("losses")]
    public required int Losses { get; set; }

    [JsonProperty ("respect")]
    public double Respect { get; set; }

    [JsonProperty ("targets")]
    public required int Targets { get; set; }

    [JsonProperty ("warhits")]
    public required int Warhits { get; set; }

    [JsonProperty ("besthit")]
    public required int Besthit { get; set; }

    [JsonProperty ("retaliations")]
    public required int Retaliations { get; set; }

    [JsonProperty ("members")]
    [NotMapped]
    public Dictionary<string, ChainParticipant> Participants { get; set; } = default!;

    public virtual List<ChainParticipant> ParticipantsList {
        get => Participants.TornDictionaryToList ();
        set => Participants = value.ToTornDictionary ();
    }

    [JsonProperty ("bonuses")]
    public virtual required List<BonusHit> Bonuses { get; set; }
}
