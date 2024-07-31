using Bartender.Net.Framework.Common.Armory;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmors : IFactionLoanables {
    [JsonProperty ("armor")]
    public IEnumerable<IFactionLoanable> Loanables { get; set; }
}
