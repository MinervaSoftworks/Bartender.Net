using Bartender.Net.Framework.Common.Reports;
using Bartender.Net.Framework.Common.Revives;
using Bartender.Net.Framework.Common.User;
using Bartender.Net.Framework.Faction.Basic;
using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.User.Ammunition;
using Bartender.Net.Framework.User.Profile;

namespace Bartender.Net.Framework.Extensions;

public static class Extensions {
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
    };

    public static CompetitionType ToCompetitionType (this string competitionType) => competitionType switch {
        "Dog Tags" => CompetitionType.DogTags,
        "Easter Egg Hunt" => CompetitionType.EasterEggHunt,
        "Elimination" => CompetitionType.Elimination,
        "Halloween" => CompetitionType.Halloween,
        "Mr & Ms Torn" => CompetitionType.MrMsTorn,
        "Rock, Paper, Scissors" => CompetitionType.RockPaperScissors,
        _ => throw new Exception ("Unknown competition type")
    };

    public static Gender ToGender (this string gender) => gender switch {
        "Enby" => Gender.Enby,
        "Female" => Gender.Female,
        "Male" => Gender.Male,
        _ => throw new Exception ("Unknown gender")
    };

    public static LastActionStatus ToLastActionStatus (this string lastActionStatus) => lastActionStatus switch {
        "Idle" => LastActionStatus.Idle,
        "Offline" => LastActionStatus.Offline,
        "Online" => LastActionStatus.Online,
        _ => throw new Exception ("Unknown last action status")
    };

    public static StatusColor ToStatusColor (this string statusColor) => statusColor switch {
        "blue" => StatusColor.Blue,
        "green" => StatusColor.Green,
        "red" => StatusColor.Red,
        _ => throw new Exception ("Unknown status color")
    };

    public static StatusState ToStatusState (this string statusState) => statusState switch {
        "Abroad" => StatusState.Abroad,
        "Fallen" => StatusState.Fallen,
        "Federal" => StatusState.Federal,
        "Hospital" => StatusState.Hospital,
        "Jail" => StatusState.Jail,
        "Okay" => StatusState.Okay,
        "Traveling" => StatusState.Traveling,
        _ => throw new Exception ("Unknown status state")
    };

    public static TornRole ToTornRole (this string tornRole) => tornRole switch {
        "Admin" => TornRole.Admin,
        "Civilian" => TornRole.Civilian,
        "Committee" => TornRole.Committee,
        "Helper" => TornRole.Helper,
        "Moderator" => TornRole.Moderator,
        "NPC" => TornRole.NPC,
        "Officer" => TornRole.Officer,
        "Reporter" => TornRole.Reporter,
        "Wiki Contributor" => TornRole.WikiContributor,
        "Wiki Editor" => TornRole.WikiEditor,
        _ => throw new Exception ("Unknown torn role")
    };

    public static ReportType ToReportType (this string reportType) => reportType switch {
        "anonymousbounties" => ReportType.AnonymousBounties,
        "friendorfoe" => ReportType.FriendOrFoe,
        "investment" => ReportType.Investment,
        "money" => ReportType.Money,
        "mostwanted" => ReportType.MostWanted,
        "references" => ReportType.References,
        "stats" => ReportType.Stats,
        "truelevel" => ReportType.TrueLevel,
        _ => throw new ArgumentException ("Invalid report type"),
    };

    public static ReviveResult ToReviveResult (this string value) => value switch {
        "success" => ReviveResult.Success,
        "failure" => ReviveResult.Failure,
        _ => throw new Exception ("Invalid Revive result")
    };

    public static Rank ToRank (this string rank) => rank switch {
        "Bronze" => Rank.Bronze,
        "Diamond" => Rank.Diamond,
        "Gold" => Rank.Gold,
        "Platinum" => Rank.Platinum,
        "Silver" => Rank.Silver,
        "Unranked" => Rank.Unranked,
        _ => throw new Exception ("Unknown rank")
    };
}
