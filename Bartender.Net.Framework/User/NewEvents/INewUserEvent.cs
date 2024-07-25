namespace Bartender.Net.Framework.User.NewEvents;

public interface INewUserEvent : IBartenderEntity {
    string Event { get; set; }
    int Timestamp { get; set; }
    bool Seen { get; set; }
}