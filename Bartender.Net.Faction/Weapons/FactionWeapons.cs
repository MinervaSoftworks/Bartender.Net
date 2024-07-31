using Bartender.Net.Framework.Faction.Common;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionWeapons : IFactionLoanables {
    [JsonProperty ("weapons")]
    public IEnumerable<IFactionLoanable> Loanables { get; set; }
}
