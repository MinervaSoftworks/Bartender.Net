namespace Bartender.Net.Framework.User.Profile;

public interface IJob : IBartenderEntity {
    int CompanyID { get; set; }
    string CompanyName { get; set; }
    string Name { get; set; }
    string Position { get; set; }
    int Type { get; set; }
}