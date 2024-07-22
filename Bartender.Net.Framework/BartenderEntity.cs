using System.Text.Json.Serialization;

namespace Bartender.Net.Framework;

public class BartenderEntity : IBartenderEntity {
    [JsonIgnore]
    public int ID { get; set; }
}
