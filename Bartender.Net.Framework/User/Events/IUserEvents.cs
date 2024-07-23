namespace Bartender.Net.Framework.User.Events; 

public interface IUserEvents {
    Dictionary<string, IUserEvent> Events { get; set; }
}