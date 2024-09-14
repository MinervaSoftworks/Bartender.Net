using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.RevivesFull;

public class ReviveFullRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("revives")]
    public required Dictionary<string, ReviveFull> Revives { get; set; }
}
