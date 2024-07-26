namespace Bartender.Net.Framework.User.Messages;

public interface IUserMessage : IBartenderEntity {
    string Name { get; }
    int Read { get; }
    int Seen { get; }
    int Timestamp { get; }
    string Title { get; }
    string Type { get; }
}