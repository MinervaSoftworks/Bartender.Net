using Bartender.Net.Framework.User.Ammunition;

namespace Bartender.Net.Framework.Extensions.User;

public static class AmmoSizeExtensions {
    public static string ToAmmoSizeString (this AmmoSize size) => size switch {
        AmmoSize.TwentyFiveACP => ".25 ACP Round",
        AmmoSize.ThreeEightyACP => ".380 ACP Round",
        AmmoSize.FortyFourSpecial => ".44 Special Round",
        AmmoSize.FortyFiveACP => ".45 ACP Round",
        AmmoSize.TwelveGauge => "12 Gauge Cartridge",
        AmmoSize.FortyMillimeter => "40mm Grenade",
        AmmoSize.FiveFourFive => "5.45mm Rifle Round",
        AmmoSize.FiveFiveSix => "5.56mm Rifle Round",
        AmmoSize.FiveSeven => "5.7mm High Vel. Round",
        AmmoSize.SevenSixTwo => "7.62 mm Rifle Round",
        AmmoSize.NineMillimeter => "9mm Parabellum Round",
        AmmoSize.Bolt => "Bolt",
        AmmoSize.Dart => "Dart",
        AmmoSize.Flare => "Flare",
        AmmoSize.Fuel => "Liter of Fuel",
        AmmoSize.RPG => "RPG",
        AmmoSize.SnowBall => "Snow Ball",
        AmmoSize.Stone => "Stone",
        AmmoSize.Warhead => "Warhead",
        _ => throw new ArgumentException ("Invalid ammo size"),
    };
}
