using Bartender.Net.Framework;

namespace Bartender.Net.Faction.Territory;

public interface IRacket : IBartenderEntity {
    int Changed { get; }
    int Created { get; }
    int Level { get; }
    string Name { get; }
    string Reward { get; }
}
