using Newtonsoft.Json;

namespace Bartender.Net.Faction.Armor;

public class FactionArmors {
    [JsonProperty ("armor")]
    public required List<FactionLoanable> Loanables { get; set; }
}
