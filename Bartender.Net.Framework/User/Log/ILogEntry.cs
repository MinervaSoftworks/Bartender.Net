namespace Bartender.Net.Framework.User.Log;

public interface ILogEntry : IBartenderEntity {
    string Category { get; }
    IDictionary<string, int> Data { get; }
    string LogType { get; }
    IDictionary<string, string> Params { get; }
    long Timestamp { get; }
    string Title { get; }
}