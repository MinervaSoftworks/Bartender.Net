namespace Bartender.Net.Framework.Faction.AttacksFull;

public interface IFactionAttackStub : IBartenderEntity {
    int AttackerFaction { get; set; }
    int AttackerId { get; set; }
    string Code { get; set; }
    int DefenderFaction { get; set; }
    int DefenderId { get; set; }
    int Respect { get; set; }
    string Result { get; set; }
    int Stealthed { get; set; }
    long TimestampEnded { get; set; }
    long TimestampStarted { get; set; }
}
