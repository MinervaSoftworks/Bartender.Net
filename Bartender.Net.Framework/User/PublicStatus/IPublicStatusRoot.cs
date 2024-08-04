using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.PublicStatus;

public interface IPublicStatusRoot : IBartenderEntity {
    bool Banned { get; }
    string PlayerName { get; }
    TornRole TornRole { get; }
    int UserID { get; }
    string Status { get; }
}