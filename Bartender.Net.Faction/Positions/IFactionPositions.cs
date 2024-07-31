namespace Bartender.Net.Faction.Positions;

public interface IFactionPositions {
    IDictionary<string, IFactionPosition> Positions { get; set; }
}
