using Bartender.Net.Framework;

namespace Bartender.Net.Faction.Territory;

public interface IRacket : IBartenderEntity {
    int Changed { get; set; }
    int Created { get; set; }
    int Level { get; set; }
    string Name { get; set; }
    string Reward { get; set; }
}
