namespace Bartender.Net.Framework.Faction.Basic;

public interface IWar : IBartenderEntity {
    long End { get; set; }
    long Start { get; set; }
    int Target { get; set; }
    decimal Winner { get; set; }
}
