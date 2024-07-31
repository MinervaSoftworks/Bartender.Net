namespace Bartender.Net.Framework.Common.Reports;

public interface IFriendOrFoeUser : IBartenderEntity {
    string Name { get; }
    int UserID { get; }
}