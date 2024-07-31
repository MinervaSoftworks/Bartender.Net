namespace Bartender.Net.Framework.Faction.Positions;

public interface IFactionPositions {
    IDictionary<string, IFactionPosition> Positions { get; set; }
}
