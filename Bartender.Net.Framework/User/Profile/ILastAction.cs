namespace Bartender.Net.Framework.User.Profile;

public interface ILastAction : IBartenderEntity {
    string Relative { get; set; }
    string Status { get; set; }
    long Timestamp { get; set; }
    LastActionStatus LastActionStatus { get; set; }
}