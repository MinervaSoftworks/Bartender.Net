using Bartender.Net.Framework.Common.Revives;

namespace Bartender.Net.Framework.Extensions.User;

public static class ReviveResultExtensions {
    public static string ToReviveResultString (this ReviveResult result) => result switch {
        ReviveResult.Failure => "failure",
        ReviveResult.Success => "success",
        _ => throw new Exception ("Invalid Revive result")
    };
}