namespace Bartender.Net.Framework.User.WorkStats;

public interface IUserWorkStats : IBartenderEntity {
    int Endurance { get; set; }
    int Intelligence { get; set; }
    int ManualLabor { get; set; }
}