using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Icons;

public class IconsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("icons")]
    [NotMapped]
    public Dictionary<string, string> Icons { get; set; } = default!;


}