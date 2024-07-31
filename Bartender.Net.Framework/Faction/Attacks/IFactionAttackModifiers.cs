namespace Bartender.Net.Framework.Faction.Attacks;

public interface IFactionAttackModifiers : IBartenderEntity {
    double ChainBonus { get; set; }
    double FairFight { get; set; }
    double GroupAttack { get; set; }
    double Overseas { get; set; }
    double Retaliation { get; set; }
    double War { get; set; }
}
