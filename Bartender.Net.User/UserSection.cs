using Bartender.Net.Framework.Common.Reports;
using Bartender.Net.Framework.Common.Revives;
using Bartender.Net.Framework.Common.RevivesFull;
using Bartender.Net.Framework.Key;
using Bartender.Net.Framework.Sections;
using Bartender.Net.User.Ammunition;
using Bartender.Net.User.Attacks;
using Bartender.Net.User.AttacksFull;
using Bartender.Net.User.Bars;
using Bartender.Net.User.Basic;
using Bartender.Net.User.BattleStats;
using Bartender.Net.User.Bazaar;
using Bartender.Net.User.Cooldowns;
using Bartender.Net.User.CrimeRecord;
using Bartender.Net.User.Discord;
using Bartender.Net.User.DisplayCase;
using Bartender.Net.User.Education;
using Bartender.Net.User.Equipment;
using Bartender.Net.User.Events;
using Bartender.Net.User.Gym;
using Bartender.Net.User.HoF;
using Bartender.Net.User.Honors;
using Bartender.Net.User.Icons;
using Bartender.Net.User.JobPoints;
using Bartender.Net.User.Log;
using Bartender.Net.User.Medals;
using Bartender.Net.User.Merits;
using Bartender.Net.User.Messages;
using Bartender.Net.User.Missions;
using Bartender.Net.User.Money;
using Bartender.Net.User.Networth;
using Bartender.Net.User.NewEvents;
using Bartender.Net.User.NewMessages;
using Bartender.Net.User.Notifications;
using Bartender.Net.User.Perks;
using Bartender.Net.User.PersonalStats;
using Bartender.Net.User.Profile;
using Bartender.Net.User.Property;
using Bartender.Net.User.PublicStatus;
using Bartender.Net.User.Refills;
using Bartender.Net.User.Reports;
using Bartender.Net.User.Revives;
using Bartender.Net.User.RevivesFull;
using Bartender.Net.User.Skills;
using Bartender.Net.User.Stocks;
using Bartender.Net.User.Travel;
using Bartender.Net.User.WeaponExp;
using Bartender.Net.User.WorkStats;

namespace Bartender.Net.User;

public class UserSection : Section {
    private static UserSection _instance = default!;

    private readonly static object _lock = new ();

    public static UserSection Instance {
        get {
            if (_instance == null) {
                lock (_lock) {
                    _instance ??= new UserSection ();
                }
            }

            return _instance;
        }
    }

    public readonly Selection Ammo;
    public readonly Selection Attacks;
    public readonly Selection AttacksFull;
    public readonly Selection Bars;
    public readonly Selection Basic;
    public readonly Selection BattleStats;
    public readonly Selection Bazaar;
    public readonly Selection Cooldowns;
    public readonly Selection CriminalRecord;
    public readonly Selection Discord;
    public readonly Selection Display;
    public readonly Selection Education;
    public readonly Selection Equipment;
    public readonly Selection Events;
    public readonly Selection Gym;
    public readonly Selection Hof;
    public readonly Selection Honors;
    public readonly Selection Icons;
    public readonly Selection JobPoints;
    public readonly Selection Log;
    public readonly Selection Medals;
    public readonly Selection Merits;
    public readonly Selection Messages;
    public readonly Selection Missions;
    public readonly Selection Money;
    public readonly Selection Networth;
    public readonly Selection NewEvents;
    public readonly Selection NewMessages;
    public readonly Selection Notifications;
    public readonly Selection Perks;
    public readonly Selection PersonalStats;
    public readonly Selection Profile;
    public readonly Selection Properties;
    public readonly Selection PublicStatus;
    public readonly Selection Refills;
    public readonly Selection Reports;
    public readonly Selection Revives;
    public readonly Selection RevivesFull;
    public readonly Selection Skills;
    public readonly Selection Stocks;
    public readonly Selection Travel;
    public readonly Selection WeaponExp;
    public readonly Selection WorkStats;

    public override IEnumerable<Selection> Selections {
        get {
            yield return Ammo;
            yield return Attacks;
            yield return AttacksFull;
            yield return Bars;
            yield return Basic;
            yield return BattleStats;
            yield return Cooldowns;
            yield return CriminalRecord;
            yield return Discord;
            yield return Display;
            yield return Education;
            yield return Equipment;
            yield return Events;
            yield return Gym;
            yield return Hof;
            yield return Honors;
            yield return Icons;
            yield return JobPoints;
            yield return Log;
            yield return Medals;
            yield return Merits;
            yield return Messages;
            yield return Missions;
            yield return Money;
            yield return Networth;
            yield return NewEvents;
            yield return NewMessages;
            yield return Notifications;
            yield return Perks;
            yield return PersonalStats;
            yield return Profile;
            yield return Properties;
            yield return PublicStatus;
            yield return Refills;
            yield return Reports;
            yield return Revives;
            yield return RevivesFull;
            yield return Skills;
            yield return Stocks;
            yield return Travel;
            yield return WeaponExp;
            yield return WorkStats;
        }
    }

    public UserSection () : base ("user") {
        Ammo = new (this, "ammo", AccessLevel.Minimal, typeof (AmmoRoot), typeof (Ammo));
        Attacks = new (this, "attacks", AccessLevel.Limited, typeof (UserAttacksRoot), typeof (UserAttack));
        AttacksFull = new (this, "attacksfull", AccessLevel.Limited, typeof (UserAttacksFullRoot), typeof (UserAttackFull));
        Bars = new (this, "bars", AccessLevel.Minimal, typeof (BarsRoot), typeof (BarsRoot));
        Basic = new (this, "basic", AccessLevel.Public, typeof (UserBasic), typeof (UserBasic));
        BattleStats = new (this, "battlestats", AccessLevel.Limited, typeof (BattleStatsRoot), typeof (BattleStatsRoot));
        Bazaar = new (this, "bazaar", AccessLevel.Limited, typeof (BazaarRoot), typeof (BazaarListing));
        Cooldowns = new (this, "cooldowns", AccessLevel.Minimal, typeof (CooldownsRoot), typeof (CooldownsRoot));
        CriminalRecord = new (this, "criminalrecord", AccessLevel.Public, typeof (CrimeRecordRoot), typeof (CrimeRecordCollection));
        Discord = new (this, "discord", AccessLevel.Limited, typeof (DiscordRoot), typeof (DiscordRecord));
        Display = new (this, "display", AccessLevel.Public, typeof (DisplayCaseRoot), typeof (DisplayCaseItem));
        Education = new (this, "education", AccessLevel.Minimal, typeof (EducationRoot), typeof (EducationRoot));
        Equipment = new (this, "equipment", AccessLevel.Minimal, typeof (EquipmentRoot), typeof (EquipmentEntry));
        Events = new (this, "events", AccessLevel.Limited, typeof (EventsRoot), typeof (Event));
        Gym = new (this, "gym", AccessLevel.Minimal, typeof (GymRoot), typeof (GymRoot));
        Hof = new (this, "hof", AccessLevel.Limited, typeof (HallOfFameRoot), typeof (HallOfFameRoot));
        Honors = new (this, "honors", AccessLevel.Minimal, typeof (HonorsRoot), typeof (HonorsRoot));
        Icons = new (this, "icons", AccessLevel.Public, typeof (IconsRoot), typeof (IconsRoot));
        JobPoints = new (this, "jobpoints", AccessLevel.Minimal, typeof (JobPointsRoot), typeof (JobPointsCollection));
        Log = new (this, "log", AccessLevel.Full, typeof (LogRoot), typeof (LogEntry));
        Medals = new (this, "medals", AccessLevel.Public, typeof (MedalsRoot), typeof (MedalsRoot));
        Merits = new (this, "merits", AccessLevel.Minimal, typeof (MeritsRoot), typeof (UserMerits));
        Messages = new (this, "messages", AccessLevel.Limited, typeof (MessagesRoot), typeof (UserMessage));
        Missions = new (this, "missions", AccessLevel.Minimal, typeof (MissionsRoot), typeof (MissionsRoot));
        Money = new (this, "money", AccessLevel.Limited, typeof (MoneyRoot), typeof (MoneyRoot));
        Networth = new (this, "networth", AccessLevel.Limited, typeof (NetworthRoot), typeof (NetworthRecord));
        NewEvents = new (this, "newevents", AccessLevel.Minimal, typeof (NewUserEventsRoot), typeof (NewUserEvent));
        NewMessages = new (this, "newmessages", AccessLevel.Minimal, typeof (NewUserMessagesRoot), typeof (UserMessage));
        Notifications = new (this, "notifications", AccessLevel.Minimal, typeof (UserNotificationsRoot), typeof (UserNotifications));
        Perks = new (this, "perks", AccessLevel.Minimal, typeof (PerksRoot), typeof (PerksRoot));
        PersonalStats = new (this, "personalstats", AccessLevel.Public, typeof (PersonalStatsRoot), typeof (PersonalStatsEntry));
        Profile = new (this, "profile", AccessLevel.Public, typeof (UserProfileRoot), typeof (UserProfileRoot));
        Properties = new (this, "properties", AccessLevel.Public, typeof (PropertiesRoot), typeof (UserProperty));
        PublicStatus = new (this, "publicstatus", AccessLevel.Public, typeof (PublicStatusRoot), typeof (PublicStatusRoot));
        Refills = new (this, "refills", AccessLevel.Minimal, typeof (RefillsRoot), typeof (RefillStates));
        Reports = new (this, "reports", AccessLevel.Limited, typeof (UserReportsRoot), typeof (Report));
        Revives = new (this, "revives", AccessLevel.Minimal, typeof (UserRevivesRoot), typeof (Revive));
        RevivesFull = new (this, "revivesfull", AccessLevel.Minimal, typeof (UserReviveFullRoot), typeof (ReviveFull));
        Skills = new (this, "skills", AccessLevel.Minimal, typeof (SkillsRoot), typeof (SkillsRoot));
        Stocks = new (this, "stocks", AccessLevel.Limited, typeof (UserStocksRoot), typeof (UserStock));
        Travel = new (this, "travel", AccessLevel.Minimal, typeof (TravelRoot), typeof (TravelEntry));
        WeaponExp = new (this, "weaponexp", AccessLevel.Minimal, typeof (WeaponExpRoot), typeof (WeaponExpEntry));
        WorkStats = new (this, "workstats", AccessLevel.Minimal, typeof (WorkStatsRoot), typeof (WorkStatsRoot));
    }
}