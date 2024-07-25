namespace Bartender.Net.Framework.User.Messages;

public interface IUserMessageCollection {
    IDictionary<string, IUserMessage> Messages { get; set; }
}