namespace Bartender.Net.Framework.Faction.Attacks;

public interface IFactionAttacks {
    Dictionary<string, IFactionAttack> Attacks { get; }
}
