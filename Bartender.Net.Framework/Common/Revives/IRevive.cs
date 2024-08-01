﻿using Bartender.Net.Framework.Common.User;

namespace Bartender.Net.Framework.Common.Revives;

public interface IRevive : IBartenderEntity {
    double Chance { get; }
    string Result { get; }
    ReviveResult ReviveResult { get; }
    int ReviverFaction { get; }
    string ReviverFactionname { get; }
    int ReviverId { get; }
    string ReviverName { get; }
    int TargetEarlyDischarge { get; }
    int TargetFaction { get; }
    string TargetFactionname { get; }
    string TargetHospitalReason { get; }
    int TargetId { get; }
    ILastAction TargetLastAction { get; }
    string TargetName { get; }
    int Timestamp { get; }
}