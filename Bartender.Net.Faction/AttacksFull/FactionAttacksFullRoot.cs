using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttacksFullRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttackFull> Stubs { get; set; } = default!;

    public virtual List<FactionAttackFull> StubsList {
        get => Stubs.TornDictionaryToList ();
        set => Stubs = value.ToTornDictionary ();
    }
}