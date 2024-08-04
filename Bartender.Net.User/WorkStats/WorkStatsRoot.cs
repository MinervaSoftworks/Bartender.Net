using Bartender.Net.Framework.Selection;
using Bartender.Net.Framework.User.WorkStats;
using Newtonsoft.Json;

namespace Bartender.Net.User.WorkStats;

public class WorkStatsRoot : IWorkStatsRoot, ISelectionRoot  {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("manual_labor")]
    public required int ManualLabor { get; set; }

    [JsonProperty ("intelligence")]
    public required int Intelligence { get; set; }

    [JsonProperty ("endurance")]
    public required int Endurance { get; set; }

    public AccessLevel AccessLevelRequired => AccessLevel.Minimal;

    public string EndpointString => "workstats";

    public string Name => "Work Stats";
}
