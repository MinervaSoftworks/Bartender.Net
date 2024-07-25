namespace Bartender.Net.Framework.User.Messages;

public interface IUserMessage : IBartenderEntity {
    string Name { get; set; }
    int Read { get; set; }
    int Seen { get; set; }
    int Timestamp { get; set; }
    string Title { get; set; }
    string Type { get; set; }
}