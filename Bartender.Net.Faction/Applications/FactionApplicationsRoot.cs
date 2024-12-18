using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplicationsRoot : BartenderEntity {
    [JsonProperty ("applications")]
    public Dictionary<string, FactionApplication> Applications { get; set; } = default!;

    public virtual List<FactionApplication> ApplicationsList {
        get => Applications.TornDictionaryToList ();
        set => Applications = value.ToTornDictionary ();
    }
}