namespace Bartender.Net.Framework.Faction.ChainReport;

public interface IBonusHit : IBartenderEntity {
    int Attacker { get; set; }
    int Chain { get; set; }
    int Defender { get; set; }
    int Respect { get; set; }
}
