using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.Basic;

public interface IUserBasic : IBartenderEntity {
    Gender Gender { get; }
    int Level { get; }
    string Name { get; }
    int PlayerID { get; }
    IStatus Status { get; }
}