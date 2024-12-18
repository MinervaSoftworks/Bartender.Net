using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttacksRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttack> Attacks { get; set; } = default!;

    public virtual List<FactionAttack> AttacksList {
        get => Attacks.TornDictionaryToList ();
        set => Attacks = value.ToTornDictionary ();
    }
}
