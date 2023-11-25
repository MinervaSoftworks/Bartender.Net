namespace Torn.Api.Net.Models.Faction;

public class RankedWar {
    public IDictionary<string, Faction> Factions { get; set; }

    public War War { get; set; }
}
