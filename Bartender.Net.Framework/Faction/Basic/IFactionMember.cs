using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Faction.Basic;

public interface IFactionMember : IBartenderEntity {
    int DaysInFaction { get; }
    ILastAction LastAction { get; }
    int Level { get; }
    string Name { get; }
    string Position { get; }
    IStatus Status { get; }
}
