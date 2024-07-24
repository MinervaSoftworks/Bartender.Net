namespace Bartender.Net.Framework.User.Log;

public interface ILogEntry : IBartenderEntity {
    string Category { get; set; }
    IDictionary<string, int> Data { get; set; }
    string LogType { get; set; }
    IDictionary<string, string> Params { get; set; }
    long Timestamp { get; set; }
    string Title { get; set; }
}