namespace Torn.Api.Net.Models.User;

public class Attack {
    public string AttackerFaction { get; set; }

    public string AttackerFactionName { get; set; }

    public string AttackerID { get; set; }

    public string AttackerName { get; set; }

    public int Chain { get; set; }

    public string Code { get; set; }

    public int DefenderFaction { get; set; }

    public string DefenderFactionName { get; set; }

    public int DefenderID { get; set; }

    public string DefenderName { get; set; }

    public Modifiers Modifiers { get; set; }

    public int Raid { get; set; }

    public int RankedWar { get; set; }

    public float Respect { get; set; }

    public float RespectGain { get; set; }

    public float RespectLoss { get; set; }

    public string Result { get; set; }

    public int Stealthed { get; set; }

    public long TimestampEnded { get; set; }

    public long TimestamStarted { get; set; }
}
