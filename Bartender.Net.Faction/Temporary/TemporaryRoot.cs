using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Temporary;

public class TemporaryRoot : BartenderEntity {
    [JsonProperty ("temporary")]
    public virtual required List<FactionTemporary> Loanables { get; set; }
}

