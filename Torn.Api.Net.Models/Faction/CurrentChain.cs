namespace Torn.Api.Net.Models.Faction;

public class CurrentChain {
    public int Cooldown { get; set; }

    public int Current { get; set; }

    public long End { get; set; }

    public int Max { get; set; }

    public float Modifier { get; set; }

    public long Start { get; set; }

    public int Timeout { get; set; }
}

public class Chain {
    public int ChainID { get; set; }

    public long End { get; set; }

    public string Respect { get; set; }

    public long Start { get; set; }
}