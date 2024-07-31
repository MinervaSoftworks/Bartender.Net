namespace Bartender.Net.Framework.Common.User;

public interface ILastAction : IBartenderEntity {
    string Status { get; }
    long Timestamp { get; }
    LastActionStatus LastActionStatus { get; }
}

// string Relative { get; }