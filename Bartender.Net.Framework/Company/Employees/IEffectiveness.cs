namespace Bartender.Net.Framework.Company.Employees;

public interface IEffectiveness : IBartenderEntity {
    int Addiction { get; }
    int DirectorEducation { get; }
    int Management { get; }
    int Merits { get; }
    int SettledIn { get; }
    int Total { get; }
    int WorkingStats { get; }
}
