namespace Bartender.Net.Framework.User.NewEvents;

public interface INewUserEventCollection {
    IDictionary<string, INewUserEvent> Events { get; }
    int PlayerID { get; }
}