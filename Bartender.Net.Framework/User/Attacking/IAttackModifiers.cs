namespace Bartender.Net.Framework.User.Attacking;

public interface IAttackModifiers : IBartenderEntity {
    double ChainBonus { get; set; }
    double FairFight { get; set; }
    int GroupAttack { get; set; }
    int Overseas { get; set; }
    int Retaliation { get; set; }
    int War { get; set; }
}