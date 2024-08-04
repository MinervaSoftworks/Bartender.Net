namespace Bartender.Net.Framework.Faction.AttacksFull;

public interface IFactionAttackStub : IBartenderEntity {
    int AttackerFaction { get; }
    int AttackerId { get; }
    string Code { get; }
    int DefenderFaction { get; }
    int DefenderId { get; }
    int Respect { get; }
    string Result { get; }
    int Stealthed { get; }
    long TimestampEnded { get; }
    long TimestampStarted { get; }
}
