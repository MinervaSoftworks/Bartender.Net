namespace Torn.Api.Net.Models.User;

public class ChainBar {
    public int Cooldown { get; set; }

    public int Current { get; set; }

    public int Maximum { get; set; }

    public float Modifier { get; set; }

    public int Timeout { get; set; }
}
