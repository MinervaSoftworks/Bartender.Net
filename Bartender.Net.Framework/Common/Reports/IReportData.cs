namespace Bartender.Net.Framework.Common.Reports;

public interface IReportData : IBartenderEntity {
    IEnumerable<string> Bounties { get; }
    IEnumerable<IReportReference> CompanyHistory { get; }
    int Defense { get; }
    int Dexterity { get; }
    IEnumerable<IFriendOrFoeUser> EnemyList { get; }
    IEnumerable<IReportReference> FactionHistory { get; }
    IEnumerable<IFriendOrFoeUser> FriendList { get; }
    int InvestedAmount { get; }
    string InvestedCompletion { get; }
    int Money { get; }
    IEnumerable<IWarrant> OtherList { get; }
    int Speed { get; }
    int Strength { get; }
    IEnumerable<IWarrant> TopList { get; }
    int TotalBattleStats { get; }
    int TrueLevel { get; }
}