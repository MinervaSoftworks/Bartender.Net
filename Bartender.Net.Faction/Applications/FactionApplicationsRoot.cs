using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Applications;

public class FactionApplicationsRoot : BartenderEntity {
    [JsonProperty ("applications")]
    public Dictionary<string, FactionApplication> Applications {
        get => ApplicationsList. ToTornDictionary();
        set => ApplicationsList = value.TornDictionaryToList ();
    }

    public virtual List<FactionApplication> ApplicationsList { get; set; } = [];
}