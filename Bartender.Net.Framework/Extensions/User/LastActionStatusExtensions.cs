using Bartender.Net.Framework.Common.User;

namespace Bartender.Net.Framework.Extensions.User;

public static class LastActionStatusExtensions {
    public static string ToLastActionStatusString (this LastActionStatus lastActionStatus) => lastActionStatus switch {
        LastActionStatus.Idle => "Idle",
        LastActionStatus.Offline => "Offline",
        LastActionStatus.Online => "Online",
        _ => throw new Exception ("Unknown last action status")
    };
}
