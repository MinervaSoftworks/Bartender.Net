namespace Torn.Api.Net.Models.Faction;

public class ChainReport {
    public int Assists { get; set; }

    public int BestHit { get; set; }

    public BonusHit[] Bonuses { get; set; }

    public int Chain { get; set; }

    public int Draws { get; set; }

    public long End { get; set; }

    public int Escapes { get; set; }

    public int FactionID { get; set; }

    public int Hospitalize { get; set; }

    public int Leave { get; set; }

    public int Losses { get; set; }

    public IDictionary<string, ChainMember> Members { get; set; }

    public int Mug { get; set; }

    public int Overseas { get; set; }

    public float Respect { get; set; }

    public int Retaliations { get; set; }

    public long Start { get; set; }

    public int Targets { get; set; }

    public int Warhits { get; set; }
}
