namespace Torn.Api.Net.Models.User;

public class AttackFull {
    public string AttackerFaction { get; set; }

    public string AttackerID { get; set; }

    public string Code { get; set; }

    public int DefenderFaction { get; set; }

    public int DefenderID { get; set; }

    public float Respect { get; set; }

    public string Result { get; set; }

    public int Stealthed { get; set; }

    public long TimestampEnded { get; set; }

    public long TimestampStarted { get; set; }
}
