namespace Bartender.Net.Framework.User.Profile;

public interface IJob : IBartenderEntity {
    int CompanyID { get; }
    string CompanyName { get; }
    string Name { get; }
    string Position { get; }
    int Type { get; }
}