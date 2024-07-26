namespace Bartender.Net.Framework.Company.Applications;

public interface IApplicationStats : IBartenderEntity {
    float Endurance { get; }
    float Intelligence { get; }
    float ManualLabor { get; }
}