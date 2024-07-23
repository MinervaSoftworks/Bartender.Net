namespace Bartender.Net.Framework.User.Attacking; 

public interface IAttackStub : IBartenderEntity {
    int AttackerFaction { get; set; }
    int AttackerId { get; set; }
    string Code { get; set; }
    int DefenderFaction { get; set; }
    int DefenderId { get; set; }
    int Respect { get; set; }
    string Result { get; set; }
    int Stealthed { get; set; }
    int TimestampEnded { get; set; }
    int TimestampStarted { get; set; }
}