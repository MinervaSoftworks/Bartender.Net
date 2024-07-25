namespace Bartender.Net.Framework.User.Profile;

public interface IMarriage : IBartenderEntity {
    int Duration { get; set; }
    int SpouseID { get; set; }
    string SpouseName { get; set; }
}