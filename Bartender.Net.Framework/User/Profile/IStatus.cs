namespace Bartender.Net.Framework.User.Profile;

public interface IStatus : IBartenderEntity {
    StatusColor StatusColor { get; set; }
    string Description { get; set; }
    string Details { get; set; }
    StatusState StatusState { get; set; }
    long Until { get; set; }
    string Color { get; set; }
    string State { get; set; }
}