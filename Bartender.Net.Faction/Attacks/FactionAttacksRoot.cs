using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttacksRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttack> Attacks { get; set; } = default!;

    public virtual List<FactionAttack> AttacksList {
        get => Attacks.TornDictionaryToList ();
        set => Attacks = value.ToTornDictionary ();
    }
}
