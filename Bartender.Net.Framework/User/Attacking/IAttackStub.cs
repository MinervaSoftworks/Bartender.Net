namespace Bartender.Net.Framework.User.Attacking;

public interface IAttackStub : IBartenderEntity {
    int AttackerFaction { get; }
    int AttackerId { get; }
    string Code { get; }
    int DefenderFaction { get; }
    int DefenderId { get; }
    int Respect { get; }
    string Result { get; }
    int Stealthed { get; }
    int TimestampEnded { get; }
    int TimestampStarted { get; }
}