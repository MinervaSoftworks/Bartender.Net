using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Faction.Basic;

public interface IFactionMember : IBartenderEntity {
    int DaysInFaction { get; set; }
    ILastAction LastAction { get; set; }
    int Level { get; set; }
    string Name { get; set; }
    string Position { get; set; }
    IStatus Status { get; set; }
}
