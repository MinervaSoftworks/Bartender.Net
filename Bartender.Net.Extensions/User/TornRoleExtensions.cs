using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Extensions.User;

public static class TornRoleExtensions {
    public static string ToTornRoleString (this TornRole role) => role switch {
        TornRole.Admin => "Admin",
        TornRole.Civilian => "Civilian",
        TornRole.Committee => "Committee",
        TornRole.Helper => "Helper",
        TornRole.Moderator => "Moderator",
        TornRole.NPC => "NPC",
        TornRole.Officer => "Officer",
        TornRole.Reporter => "Reporter",
        TornRole.WikiContributor => "Wiki Contributor",
        TornRole.WikiEditor => "Wiki Editor",
        _ => throw new Exception ("Unknown torn role")
    };
}
