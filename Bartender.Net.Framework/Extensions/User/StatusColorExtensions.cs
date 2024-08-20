using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Extensions.User;

public static class StatusColorExtensions {
    public static string ToStatusColorString (this StatusColor statusColor) => statusColor switch {
        StatusColor.Blue => "blue",
        StatusColor.Green => "green",
        StatusColor.Red => "red",
        _ => throw new Exception ("Unknown status color")
    };
}
