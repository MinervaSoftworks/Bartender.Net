namespace Bartender.Net.Framework.User.WorkStats;

public interface IUserWorkStats : IBartenderEntity {
    int Endurance { get; }
    int Intelligence { get; }
    int ManualLabor { get; }
}