using Bartender.Net.Framework.User.Ammunition;

namespace Bartender.Net.Extensions.User;

public static class AmmoTypeExtensions {
    public static string ToAmmoTypeString (this AmmoType type) => type switch {
        AmmoType.HollowPoint => "Hollow Point",
        AmmoType.Incendiary => "Incendiary",
        AmmoType.Piercing => "Piercing",
        AmmoType.Standard => "Standard",
        AmmoType.Tracer => "Tracer",
        _ => throw new ArgumentException ("Invalid ammo type"),
    };
}
