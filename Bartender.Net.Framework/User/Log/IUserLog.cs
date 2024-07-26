namespace Bartender.Net.Framework.User.Log;

public interface IUserLog {
    IDictionary<int, ILogEntry> Entries { get; }
}