using Bartender.Net.Framework;
using Bartender.Net.Framework.Extensions;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.Faction.Chains;

public class ChainsRoot : BartenderEntity {
    [JsonProperty ("chains")]
    [NotMapped]
    public Dictionary<string, FactionChain> Chains { get; set; } = default!;

    public virtual List<FactionChain> ChainsList {
        get => Chains.TornDictionaryToList ();
        set => Chains = value.ToTornDictionary ();
    }
}
