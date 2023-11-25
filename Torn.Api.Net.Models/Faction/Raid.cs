namespace Torn.Api.Net.Models.Faction;

public class Raid {
    public int DefenderScore { get; set; }

    public int DefenderFaction { get; set; }

    public string RaiderScore { get; set; }

    public int RaidingFaction { get; set; }

    public long StartTime { get; set; }
}
