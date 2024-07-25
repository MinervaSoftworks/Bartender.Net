namespace Bartender.Net.Framework.User.Reports;

public interface IFriendOrFoeUser : IBartenderEntity {
    string Name { get; set; }
    int UserID { get; set; }
}