using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Company.Profile;

public interface ICompanyEmployee : IBartenderEntity {
    int DaysInCompany { get; set; }
    ILastAction LastAction { get; set; }
    string Name { get; set; }
    string Position { get; set; }
}