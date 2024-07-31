using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.PublicStatus;

public interface IUserPublicStatus : IBartenderEntity {
    bool Banned { get; }
    string PlayerName { get; }
    TornRole TornRole { get; }
    int UserID { get; }
    string Status { get; }
}