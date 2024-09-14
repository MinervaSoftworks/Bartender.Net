using Newtonsoft.Json;

namespace Bartender.Net.Framework.Common.Revives;

public class RevivesRoot : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty("revives")]
    public required List<Revive> Revives { get; set; }
}
