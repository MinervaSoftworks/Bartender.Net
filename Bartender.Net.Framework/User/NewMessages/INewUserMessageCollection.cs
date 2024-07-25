using Bartender.Net.Framework.User.Messages;

namespace Bartender.Net.Framework.User.NewMessages;

public interface INewUserMessageCollection : IBartenderEntity {
    IDictionary<string, IUserMessage> Messages { get; set; }
    int PlayerID { get; set; }
}