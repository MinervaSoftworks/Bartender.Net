namespace Bartender.Net.Framework.Faction.ChainReport;

public interface IBonusHit : IBartenderEntity {
    int Attacker { get; }
    int Chain { get; }
    int Defender { get; }
    int Respect { get; }
}
