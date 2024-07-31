using Bartender.Net.Framework.Faction.Common;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionTemporary : IFactionLoanables {
    [JsonProperty ("temporary")]
    public IEnumerable<IFactionLoanable> Loanables { get; set; }
}
