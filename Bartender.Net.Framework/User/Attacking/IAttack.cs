namespace Bartender.Net.Framework.User.Attacking;

public interface IAttack : IBartenderEntity {
    int AttackerFaction { get; }
    string AttackerFactionName { get; }
    int AttackerId { get; }
    string AttackerName { get; }
    int Chain { get; }
    string Code { get; }
    int DefenderFaction { get; }
    string DefenderFactionname { get; }
    int DefenderId { get; }
    string DefenderName { get; }
    IAttackModifiers Modifiers { get; }
    int Raid { get; }
    int RankedWar { get; }
    double Respect { get; }
    double RespectGain { get; }
    double RespectLoss { get; }
    string Result { get; }
    int Stealthed { get; }
    int TimestampEnded { get; }
    int TimestampStarted { get; }
}