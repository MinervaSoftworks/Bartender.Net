namespace Bartender.Net.Framework.User.Attacking;

public interface IAttackModifiers : IBartenderEntity {
    double ChainBonus { get; }
    double FairFight { get; }
    int GroupAttack { get; }
    int Overseas { get; }
    int Retaliation { get; }
    int War { get; }
}