namespace Bartender.Net.Framework.User.NewEvents;

public interface INewUserEvent : IBartenderEntity {
    string Event { get; }
    int Timestamp { get; }
    bool Seen { get; }
}