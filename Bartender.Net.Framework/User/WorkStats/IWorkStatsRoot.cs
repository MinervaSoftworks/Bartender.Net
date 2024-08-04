namespace Bartender.Net.Framework.User.WorkStats;

public interface IWorkStatsRoot : IBartenderEntity {
    int Endurance { get; }
    int Intelligence { get; }
    int ManualLabor { get; }
}