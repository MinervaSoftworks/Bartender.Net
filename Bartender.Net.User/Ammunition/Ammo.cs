using Bartender.Net.Framework;
using Newtonsoft.Json;

namespace Bartender.Net.User.Ammunition;

public class Ammo : BartenderEntity {
    [JsonProperty ("ammoID")]
    public required int AmmoID { get; set; }

    [JsonProperty ("equipped")]
    public required bool Equipped { get; set; }

    [JsonProperty ("quantity")]
    public required int Quantity { get; set; }

    [JsonProperty ("size")]
    public required string Size {
        get => AmmoSizeToSize (AmmoSize);
        set => AmmoSize = SizeToAmmoSize (value);
    }

    [JsonIgnore]
    public required AmmoSize AmmoSize { get; set; }

    [JsonProperty ("type")]
    public required string Type {
        get => AmmoTypeToType (AmmoType);
        set => AmmoType = TypeToAmmoType (value);
    }

    [JsonIgnore]
    public required AmmoType AmmoType { get; set; }

    [JsonProperty ("typeID")]
    public required int TypeID { get; set; }

    public static AmmoSize SizeToAmmoSize (string size) => size switch {
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

    public static string AmmoSizeToSize (AmmoSize size) => size switch {
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
        AmmoSize.Flare => "Flare", // Assuming Flare is added to the enum
        AmmoSize.Fuel => "Liter of Fuel",
        AmmoSize.RPG => "RPG",
        AmmoSize.SnowBall => "Snow Ball",
        AmmoSize.Stone => "Stone",
        AmmoSize.Warhead => "Warhead",
        _ => throw new ArgumentException ("Invalid AmmoSize value"),
    };

    public static AmmoType TypeToAmmoType (string type) => type switch {
        "Hollow Point" => AmmoType.HollowPoint,
        "Incendiary" => AmmoType.Incendiary,
        "Piercing" => AmmoType.Piercing,
        "Standard" => AmmoType.Standard,
        "Tracer" => AmmoType.Tracer,
        _ => throw new ArgumentException ("Invalid ammo type"),
    };

    public static string AmmoTypeToType (AmmoType type) => type switch {
        AmmoType.HollowPoint => "Hollow Point",
        AmmoType.Incendiary => "Incendiary",
        AmmoType.Piercing => "Piercing",
        AmmoType.Standard => "Standard",
        AmmoType.Tracer => "Tracer",
        _ => throw new ArgumentException ("Invalid AmmoType value"),
    };
}
