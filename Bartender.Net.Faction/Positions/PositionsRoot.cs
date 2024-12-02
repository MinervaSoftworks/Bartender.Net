using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Positions;

public class PositionsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("positions")]
    [NotMapped]
    public Dictionary<string, Position> Positions { get; set; } = default!;

    public virtual List<Position> PositionsList {
        get => Positions.TornDictionaryToList ();
        set => Positions = value.ToTornDictionary ();
    }
}
