using Bartender.Net.Framework.Faction.Common;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmors : IFactionLoanables {
    [JsonProperty ("armor")]
    public IEnumerable<IFactionLoanable> Loanables { get; set; }
}
