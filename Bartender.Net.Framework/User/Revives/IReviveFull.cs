using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.Revives;

public interface IReviveFull : IBartenderEntity {
    double Chance { get; }
    string Result { get; }
    int ReviverFaction { get; }
    int ReviverId { get; }
    int TargetEarlyDischarge { get; }
    int TargetFaction { get; }
    string TargetHospitalReason { get; }
    int TargetId { get; }
    ILastAction TargetLastAction { get; }
    int Timestamp { get; }
    int TimeStamp { get; }
}