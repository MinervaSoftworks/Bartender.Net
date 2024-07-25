namespace Bartender.Net.Framework.User.Reports;

public interface IReportData : IBartenderEntity {
    IEnumerable<string> Bounties { get; set; }
    IEnumerable<IReportReference> CompanyHistory { get; set; }
    int Defense { get; set; }
    int Dexterity { get; set; }
    IEnumerable<IFriendOrFoeUser> EnemyList { get; set; }
    IEnumerable<IReportReference> FactionHistory { get; set; }
    IEnumerable<IFriendOrFoeUser> FriendList { get; set; }
    int InvestedAmount { get; set; }
    string InvestedCompletion { get; set; }
    int Money { get; set; }
    IEnumerable<IWarrant> OtherList { get; set; }
    int Speed { get; set; }
    int Strength { get; set; }
    IEnumerable<IWarrant> TopList { get; set; }
    int TotalBattleStats { get; set; }
    int TrueLevel { get; set; }
}