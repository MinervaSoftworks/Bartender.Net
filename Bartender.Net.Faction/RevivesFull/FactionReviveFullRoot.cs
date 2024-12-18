using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.RevivesFull;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.RevivesFull;

public class FactionReviveFullRoot : BartenderEntity {
    [JsonProperty ("revives")]
    [NotMapped]
    public Dictionary<string, ReviveFull> Revives { get; set; } = default!;

    public virtual List<ReviveFull> RevivesList {
        get => Revives.TornDictionaryToList ();
        set => Revives = value.ToTornDictionary ();
    }
}
