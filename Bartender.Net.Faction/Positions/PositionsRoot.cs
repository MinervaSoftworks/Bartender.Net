using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Positions;

public class PositionsRoot : BartenderEntity {
    [JsonProperty ("positions")]
    [NotMapped]
    public Dictionary<string, FactionPosition> Positions { get; set; } = [];

    public virtual List<FactionPosition> PositionsList { get; set; } = [];
}
