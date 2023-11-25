using Torn.Api.Net.Models.User;

namespace Torn.Api.Net.Models.Faction;

public class Member {
    public int DaysInFaction { get; set; }

    public LastAction LastAction { get; set; }

    public int Level { get; set; }

    public string Name { get; set; }

    public string Position { get; set; }

    public Status Status { get; set; }
}
