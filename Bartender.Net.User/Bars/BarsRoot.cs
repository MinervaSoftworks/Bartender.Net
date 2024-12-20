using Bartender.Net.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bartender.Net.User.Bars;

public class BarsRoot : BartenderEntity {
    [JsonProperty ("server_time")]
    public required int ServerTime { get; set; }

    [JsonProperty ("happy")]
    [NotMapped]
    public virtual required Bar Happy { get; set; }

    [JsonProperty ("life")]
    [NotMapped]
    public virtual required Bar Life { get; set; }

    [JsonProperty ("energy")]
    [NotMapped]
    public virtual required Bar Energy { get; set; }

    [JsonProperty ("nerve")]
    [NotMapped]
    public virtual required Bar Nerve { get; set; }

    public virtual List<Bar> Bars { get; set; } = [];

    public virtual List<int> BarIDs { get; set; } = [];

    [JsonProperty ("chain")]
    public virtual required ChainBar Chain { get; set; }
}
