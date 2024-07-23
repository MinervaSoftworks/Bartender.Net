namespace Bartender.Net.Framework.User.Attacking;

public interface IAttack : IBartenderEntity {
    int AttackerFaction { get; set; }
    string AttackerFactionName { get; set; }
    int AttackerId { get; set; }
    string AttackerName { get; set; }
    int Chain { get; set; }
    string Code { get; set; }
    int DefenderFaction { get; set; }
    string DefenderFactionname { get; set; }
    int DefenderId { get; set; }
    string DefenderName { get; set; }
    IAttackModifiers Modifiers { get; set; }
    int Raid { get; set; }
    int RankedWar { get; set; }
    double Respect { get; set; }
    double RespectGain { get; set; }
    double RespectLoss { get; set; }
    string Result { get; set; }
    int Stealthed { get; set; }
    int TimestampEnded { get; set; }
    int TimestampStarted { get; set; }
}