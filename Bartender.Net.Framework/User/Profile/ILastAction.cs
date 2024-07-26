namespace Bartender.Net.Framework.User.Profile;

public interface ILastAction : IBartenderEntity {
    string Relative { get; }
    string Status { get; }
    long Timestamp { get; }
    LastActionStatus LastActionStatus { get; }
}