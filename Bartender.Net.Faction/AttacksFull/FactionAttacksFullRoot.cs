using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.AttacksFull;

public class FactionAttacksFullRoot : BartenderEntity {
    [JsonProperty ("attacks")]
    public Dictionary<string, FactionAttackFull> Stubs {
        get => StubsList.ToTornDictionary ();
        set => StubsList = value.TornDictionaryToList ();
    }

    public virtual List<FactionAttackFull> StubsList { get; set; } = [];
}