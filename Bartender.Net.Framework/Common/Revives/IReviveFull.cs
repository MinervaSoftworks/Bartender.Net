using Bartender.Net.Framework.Common.User;

namespace Bartender.Net.Framework.Common.Revives;

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