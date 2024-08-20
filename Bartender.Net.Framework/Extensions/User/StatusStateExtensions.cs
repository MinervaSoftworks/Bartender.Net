using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Extensions.User;

public static class StatusStateExtensions {
    public static string ToStatusStateString (this StatusState statusState) => statusState switch {
        StatusState.Abroad => "Abroad",
        StatusState.Fallen => "Fallen",
        StatusState.Federal => "Federal",
        StatusState.Hospital => "Hospital",
        StatusState.Jail => "Jail",
        StatusState.Okay => "Okay",
        StatusState.Traveling => "Traveling",
        _ => throw new Exception ("Unknown status state")
    };
}
