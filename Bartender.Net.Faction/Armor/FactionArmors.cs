using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmors {
    [JsonProperty ("armor")]
    public List<FactionLoanable> Loanables { get; set; }
}
