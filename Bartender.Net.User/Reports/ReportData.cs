using Bartender.Net.Framework.User.Reports;
using Newtonsoft.Json;

namespace Bartender.Net.User.Reports;

public class ReportData : IReportData {
    [JsonIgnore]
    public int ID { get; set; }

    [JsonProperty ("bounties")]
    public required IEnumerable<string> Bounties { get; set; }

    [JsonProperty ("company_history")]
    public required IEnumerable<IReportReference> CompanyHistory { get; set; }

    [JsonProperty ("defense")]
    public required int Defense { get; set; }

    [JsonProperty ("dexterity")]
    public required int Dexterity { get; set; }

    [JsonProperty ("enemylist")]
    public required IEnumerable<IFriendOrFoeUser> EnemyList { get; set; }

    [JsonProperty ("faction_history")]
    public required IEnumerable<IReportReference> FactionHistory { get; set; }

    [JsonProperty ("friendlist")]
    public required IEnumerable<IFriendOrFoeUser> FriendList { get; set; }

    [JsonProperty ("invested_amount")]
    public required int InvestedAmount { get; set; }

    [JsonProperty ("invested_completion")]
    public required string InvestedCompletion { get; set; }

    [JsonProperty ("money")]
    public required int Money { get; set; }

    [JsonProperty ("otherlist")]
    public required IEnumerable<IWarrant> OtherList { get; set; }

    [JsonProperty ("speed")]
    public required int Speed { get; set; }

    [JsonProperty ("strength")]
    public required int Strength { get; set; }

    [JsonProperty ("toplist")]
    public required IEnumerable<IWarrant> TopList { get; set; }

    [JsonProperty ("total_battlestats")]
    public required int TotalBattleStats { get; set; }

    [JsonProperty ("truelevel")]
    public required int TrueLevel { get; set; }
}
