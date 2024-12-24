using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Icons;

public class IconsRoot : BartenderEntity {
    [JsonProperty ("icons")]
    [NotMapped]
    public Dictionary<string, string> Icons { get; set; } = default!;
}