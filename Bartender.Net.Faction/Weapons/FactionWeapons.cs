using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionWeapons : IFactionLoanables {
    [JsonProperty ("weapons")]
    public IEnumerable<IFactionLoanable> Loanables { get; set; }
}
