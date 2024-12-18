using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Upgrades;

public class FactionUpgradesRoot : BartenderEntity {
    [JsonProperty ("peace")]
    [NotMapped]
    public Dictionary<string, FactionUpgrade> Peace { get; set; } = default!;

    public virtual List<FactionUpgrade> PeaceList {
        get => Peace.TornDictionaryToList ();
        set => Peace = value.ToTornDictionary ();
    }

    [JsonProperty ("state")]
    public required string StateName { get; set; }

    [JsonProperty ("upgrades")]
    [NotMapped]
    public Dictionary<string, FactionUpgrade> Upgrades { get; set; } = default!;

    public virtual List<FactionUpgrade> UpgradesList {
        get => Upgrades.TornDictionaryToList ();
        set => Upgrades = value.ToTornDictionary ();
    }

    [JsonProperty ("war")]
    [NotMapped]
    public Dictionary<string, FactionUpgrade> War { get; set; } = default!;

    public virtual List<FactionUpgrade> WarList {
        get => War.TornDictionaryToList ();
        set => War = value.ToTornDictionary ();
    }
}
