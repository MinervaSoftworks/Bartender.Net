using Bartender.Net.Framework.Common.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.Common.Reports;

public class ReportData : IReportData {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bounties")]
    public IEnumerable<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public IEnumerable<IReportReference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public IEnumerable<IFriendOrFoeUser> EnemyList { get; set; }

    [JsonProperty ("faction_history")]
    public IEnumerable<IReportReference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public IEnumerable<IFriendOrFoeUser> FriendList { get; set; }

    [JsonProperty ("invested_amount")]
    public int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public int Money { get; set; }

    [JsonProperty ("otherlist")]
    public IEnumerable<IWarrant> OtherList { get; set; }

    [JsonProperty ("speed")]
    public int Speed { get; set; }

    [JsonProperty ("strength")]
    public int Strength { get; set; }

    [JsonProperty ("toplist")]
    public IEnumerable<IWarrant> TopList { get; set; }

    [JsonProperty ("total_battlestats")]
    public int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public int TrueLevel { get; set; }
}
