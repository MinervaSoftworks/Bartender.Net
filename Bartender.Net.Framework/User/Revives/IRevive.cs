using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.User.Revives;

public interface IRevive : IBartenderEntity {
    double Chance { get; set; }
    string Result { get; set; }
    ReviveResult ReviveResult { get; }
    int ReviverFaction { get; set; }
    string ReviverFactionname { get; set; }
    int ReviverId { get; set; }
    string ReviverName { get; set; }
    int TargetEarlyDischarge { get; set; }
    int TargetFaction { get; set; }
    string TargetFactionname { get; set; }
    string TargetHospitalReason { get; set; }
    int TargetId { get; set; }
    ILastAction TargetLastAction { get; set; }
    string TargetName { get; set; }
    int Timestamp { get; set; }
}