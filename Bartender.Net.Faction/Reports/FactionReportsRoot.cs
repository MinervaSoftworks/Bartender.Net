using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Reports;

public class FactionReportsRoot : BartenderEntity {
    [JsonIgnore]
    public override int ID { get; set; }

    [JsonProperty ("reports")]
    public virtual required List<Report> Reports { get; set; }
}
