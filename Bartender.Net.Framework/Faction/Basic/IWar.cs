namespace Bartender.Net.Framework.Faction.Basic;

public interface IWar : IBartenderEntity {
    long End { get; }
    long Start { get; }
    int Target { get; }
    decimal Winner { get; }
}
