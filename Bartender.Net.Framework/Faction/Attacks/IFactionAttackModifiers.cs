namespace Bartender.Net.Framework.Faction.Attacks;

public interface IFactionAttackModifiers : IBartenderEntity {
    double ChainBonus { get; }
    double FairFight { get; }
    double GroupAttack { get; }
    double Overseas { get; }
    double Retaliation { get; }
    double War { get; }
}
