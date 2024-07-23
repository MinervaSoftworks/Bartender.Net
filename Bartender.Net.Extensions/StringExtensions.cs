using Bartender.Net.Framework.Sections;
using Bartender.Net.Framework.User.Ammunition;

namespace Bartender.Net.Extensions;

public static class StringExtensions {
    public static AmmoType ToAmmoType (this string type) => type switch {
        "Hollow Point" => AmmoType.HollowPoint,
        "Incendiary" => AmmoType.Incendiary,
        "Piercing" => AmmoType.Piercing,
        "Standard" => AmmoType.Standard,
        "Tracer" => AmmoType.Tracer,
        _ => throw new ArgumentException ("Invalid ammo type"),
    };

    public static AmmoSize ToAmmoSize (this string size) => size switch {
        ".25 ACP Round" => AmmoSize.TwentyFiveACP,
        ".380 ACP Round" => AmmoSize.ThreeEightyACP,
        ".44 Special Round" => AmmoSize.FortyFourSpecial,
        ".45 ACP Round" => AmmoSize.FortyFiveACP,
        "12 Gauge Cartridge" => AmmoSize.TwelveGauge,
        "40mm Grenade" => AmmoSize.FortyMillimeter,
        "5.45mm Rifle Round" => AmmoSize.FiveFourFive,
        "5.56mm Rifle Round" => AmmoSize.FiveFiveSix,
        "5.7mm High Vel. Round" => AmmoSize.FiveSeven,
        "7.62 mm Rifle Round" => AmmoSize.SevenSixTwo,
        "9mm Parabellum Round" => AmmoSize.NineMillimeter,
        "Bolt" => AmmoSize.Bolt,
        "Dart" => AmmoSize.Dart,
        "Flare" => AmmoSize.Flare,
        "Liter of Fuel" => AmmoSize.Fuel,
        "RPG" => AmmoSize.RPG,
        "Snow Ball" => AmmoSize.SnowBall,
        "Stone" => AmmoSize.Stone,
        "Warhead" => AmmoSize.Warhead,
        _ => throw new ArgumentException ("Invalid ammo size"),
    };

    public static AccessLevel ToAccessLevel (this string level) => level switch {
        "Public" => AccessLevel.Public,
        "Minimal Access" => AccessLevel.Minimal,
        "Limited Access" => AccessLevel.Limited,
        "Full Access" => AccessLevel.Full,
        _ => throw new NotImplementedException ("Invalid access level"),
    }
}
