namespace Bartender.Net.Framework.User.Profile;

public interface IMarriage : IBartenderEntity {
    int Duration { get; }
    int SpouseID { get; }
    string SpouseName { get; }
}