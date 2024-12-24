using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Upgrades;

public class FactionUpgradesRoot : BartenderEntity {
    [JsonProperty ("peace")]
    [NotMapped]
    public Dictionary<string, FactionUpgrade> Peace {
        get => PeaceList.ToTornDictionary ();
        set => PeaceList = value.TornDictionaryToList ();
    }

    public virtual List<FactionUpgrade> PeaceList { get; set; } = [];

    [JsonProperty ("state")]
    public required string StateName { get; set; }

    [JsonProperty ("upgrades")]
    [NotMapped]
    public Dictionary<string, FactionUpgrade> Upgrades {
        get => UpgradesList.ToTornDictionary ();
        set => UpgradesList = value.TornDictionaryToList ();
    }

    public virtual List<FactionUpgrade> UpgradesList { get; set; } = [];

    [JsonProperty ("war")]
    [NotMapped]
    public Dictionary<string, FactionUpgrade> War {
        get => WarList.ToTornDictionary ();
        set => WarList = value.TornDictionaryToList ();
    }

    public virtual List<FactionUpgrade> WarList { get; set; } = [];
}
