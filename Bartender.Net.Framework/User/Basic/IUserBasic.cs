using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.Basic;

public interface IUserBasic : IBartenderEntity {
    Gender Gender { get; set; }
    int Level { get; set; }
    string Name { get; set; }
    int PlayerID { get; set; }
    IStatus Status { get; set; }
}