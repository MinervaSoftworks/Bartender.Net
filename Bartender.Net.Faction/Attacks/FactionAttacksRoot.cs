using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Attacks;

public class FactionAttacksRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttack> Attacks {
        get => AttacksList.ToTornDictionary ();
        set => AttacksList = value.TornDictionaryToList ();
    }

    public virtual List<FactionAttack> AttacksList { get; set; } = [];
}
