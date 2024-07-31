using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionTemporary : IFactionLoanables {
    [JsonProperty ("temporary")]
    public IEnumerable<IFactionLoanable> Loanables { get; set; }
}
