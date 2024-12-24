using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Chains;

public class ChainsRoot : BartenderEntity {
    [JsonProperty ("chains")]
    [NotMapped]
    public Dictionary<string, FactionChain> Chains {
        get => ChainsList.ToTornDictionary ();
        set => ChainsList = value.TornDictionaryToList ();
    }

    public virtual List<FactionChain> ChainsList { get; set; } = [];
}
