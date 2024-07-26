namespace Bartender.Net.Framework.User.Profile;

public interface IStatus : IBartenderEntity {
    StatusColor StatusColor { get; }
    string Description { get; }
    string Details { get; }
    StatusState StatusState { get; }
    long Until { get; }
    string Color { get; }
    string State { get; }
}