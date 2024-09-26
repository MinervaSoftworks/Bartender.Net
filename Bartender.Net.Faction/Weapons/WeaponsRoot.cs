using Bartender.Net.Faction.Common.Armory;
using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Weapons;

public class WeaponsRoot {
    [JsonProperty ("weapons")]
    public required List<FactionLoanable> Loanables { get; set; }
}
