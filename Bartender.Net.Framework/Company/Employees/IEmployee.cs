using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Company.Employees;

public interface IEmployee : IBartenderEntity {
    int DaysInCompany { get; }
    IEffectiveness Effectiveness { get; }
    int Endurance { get; }
    int Intelligence { get; }
    ILastAction LastAction { get; }
    int ManualLabor { get; }
    string Name { get; }
    string Position { get; }
    IStatus Status { get; }
}