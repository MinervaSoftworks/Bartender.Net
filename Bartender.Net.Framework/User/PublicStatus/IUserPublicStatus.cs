using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.PublicStatus;

public interface IUserPublicStatus  : IBartenderEntity {
    bool Banned { get; set; }
    string PlayerName { get; set; }
    TornRole TornRole { get; set; }
    int UserID { get; set; }
    string Status { get; set; }
}