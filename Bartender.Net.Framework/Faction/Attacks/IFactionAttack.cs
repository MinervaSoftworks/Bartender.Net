namespace Bartender.Net.Framework.Faction.Attacks;

public interface IFactionAttack : IBartenderEntity {
    int AttackerFaction { get; }
    string AttackerFactionName { get; }
    int AttackerId { get; }
    string AttackerName { get; }
    int Chain { get; }
    string Code { get; }
    int DefenderFaction { get; }
    string DefenderFactionName { get; }
    int DefenderId { get; }
    string DefenderName { get; }
    IFactionAttackModifiers Modifiers { get; }
    int Raid { get; }
    int RankedWar { get; }
    double Respect { get; }
    double RespectGain { get; }
    double RespectLoss { get; }
    string Result { get; }
    int Stealthed { get; }
    long TimestampEnded { get; }
    long TimestampStarted { get; }
}
