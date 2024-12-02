using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Upgrades;

public class UpgradesRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("peace")]
    [NotMapped]
    public Dictionary<string, Upgrade> Peace { get; set; } = default!;

    public virtual List<Upgrade> PeaceList {
        get => Peace.TornDictionaryToList ();
        set => Peace = value.ToTornDictionary ();
    }

    [JsonProperty ("state")]
    public required string StateName { get; set; }

    [JsonProperty ("upgrades")]
    [NotMapped]
    public Dictionary<string, Upgrade> Upgrades { get; set; } = default!;

    public virtual List<Upgrade> UpgradesList {
        get => Upgrades.TornDictionaryToList ();
        set => Upgrades = value.ToTornDictionary ();
    }

    [JsonProperty ("war")]
    [NotMapped]
    public Dictionary<string, Upgrade> War { get; set; } = default!;

    public virtual List<Upgrade> WarList {
        get => War.TornDictionaryToList ();
        set => War = value.ToTornDictionary ();
    }
}
