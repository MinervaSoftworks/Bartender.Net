using Bartender.Net.Framework.Common.User;

namespace Bartender.Net.Framework.Company.Profile;

public interface ICompanyEmployee : IBartenderEntity {
    int DaysInCompany { get; }
    ILastAction LastAction { get; }
    string Name { get; }
    string Position { get; }
}