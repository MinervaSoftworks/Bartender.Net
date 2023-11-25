namespace Torn.Api.Net.Models.Faction;

// Attacks and AttacksFull from User cause DRY

public class Basic {
    public int Age { get; set; }

    public int BestChain { get; set; }

    public int Capacity { get; set; }

    public int CoLeader { get; set; }

    public int ID { get; set; }

    public IDictionary<string, Member> Members { get; set; }

    public string Name { get; set; }

    public IDictionary<string, long> Peace { get; set; }

    public Raid[] RaidWars { get; set; }

    public Ranking Rank { get; set; }

    public IDictionary<string, RankedWar> RankedWars { get; set; }

    public int Respect { get; set; }

    public string Tag { get; set; }

    public string TagImage { get; set; }

    public TerritoryWar[] TerritoryWars { get; set; }
}
