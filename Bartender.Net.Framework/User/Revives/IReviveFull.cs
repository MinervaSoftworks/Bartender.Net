using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.Revives;

public interface IReviveFull : IBartenderEntity {
    double Chance { get; set; }
    string Result { get; set; }
    int ReviverFaction { get; set; }
    int ReviverId { get; set; }
    int TargetEarlyDischarge { get; set; }
    int TargetFaction { get; set; }
    string TargetHospitalReason { get; set; }
    int TargetId { get; set; }
    ILastAction TargetLastAction { get; set; }
    int Timestamp { get; set; }
    int TimeStamp { get; set; }
}