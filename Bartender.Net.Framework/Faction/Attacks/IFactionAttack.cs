namespace Bartender.Net.Framework.Faction.Attacks;

public interface IFactionAttack : IBartenderEntity {
    int AttackerFaction { get; set; }
    string AttackerFactionName { get; set; }
    int AttackerId { get; set; }
    string AttackerName { get; set; }
    int Chain { get; set; }
    string Code { get; set; }
    int DefenderFaction { get; set; }
    string DefenderFactionName { get; set; }
    int DefenderId { get; set; }
    string DefenderName { get; set; }
    IFactionAttackModifiers Modifiers { get; set; }
    int Raid { get; set; }
    int RankedWar { get; set; }
    double Respect { get; set; }
    double RespectGain { get; set; }
    double RespectLoss { get; set; }
    string Result { get; set; }
    int Stealthed { get; set; }
    long TimestampEnded { get; set; }
    long TimestampStarted { get; set; }
}
