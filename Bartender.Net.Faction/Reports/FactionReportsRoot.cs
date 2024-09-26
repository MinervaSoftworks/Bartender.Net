using Bartender.Net.Framework;
using Bartender.Net.Framework.Common.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.Faction.Reports;

public class FactionReportsRoot {
    [JsonProperty ("reports")]
    public required List<Report> Reports { get; set; }
}
