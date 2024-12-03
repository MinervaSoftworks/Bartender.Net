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

    public readonly Selection UserAmmo;
    public readonly Selection UserAttacks;
    public readonly Selection UserAttacksFull;
    public readonly Selection UserBars;
    public readonly Selection UserBasic;
    public readonly Selection UserBattleStats;
    public readonly Selection UserBazaar;
    public readonly Selection UserCooldowns;
    public readonly Selection UserCriminalRecord;
    public readonly Selection UserDiscord;
    public readonly Selection UserDisplay;
    public readonly Selection UserEducation;
    public readonly Selection UserEquipment;
    public readonly Selection UserEvents;
    public readonly Selection UserGym;
    public readonly Selection UserHof;
    public readonly Selection UserHonors;
    public readonly Selection UserIcons;
    public readonly Selection UserJobPoints;
    public readonly Selection UserLog;
    public readonly Selection UserMedals;
    public readonly Selection UserMerits;
    public readonly Selection UserMessages;
    public readonly Selection UserMissions;
    public readonly Selection UserMoney;
    public readonly Selection UserNetworth;
    public readonly Selection UserNewEvents;
    public readonly Selection UserNewMessages;
    public readonly Selection UserNotifications;
    public readonly Selection UserPerks;
    public readonly Selection UserPersonalStats;
    public readonly Selection UserProfile;
    public readonly Selection UserProperties;
    public readonly Selection UserPublicStatus;
    public readonly Selection UserRefills;
    public readonly Selection UserReports;
    public readonly Selection UserRevives;
    public readonly Selection UserRevivesFull;
    public readonly Selection UserSkills;
    public readonly Selection UserStocks;
    public readonly Selection UserTravel;
    public readonly Selection UserWeaponExp;
    public readonly Selection UserWorkStats;

    public override IEnumerable<Selection> Selections {
        get {
            yield return UserAmmo;
            yield return UserAttacks;
            yield return UserAttacksFull;
            yield return UserBars;
            yield return UserBasic;
            yield return UserBattleStats;
            yield return UserCooldowns;
            yield return UserCriminalRecord;
            yield return UserDiscord;
            yield return UserDisplay;
            yield return UserEducation;
            yield return UserEquipment;
            yield return UserEvents;
            yield return UserGym;
            yield return UserHof;
            yield return UserHonors;
            yield return UserIcons;
            yield return UserJobPoints;
            yield return UserLog;
            yield return UserMedals;
            yield return UserMerits;
            yield return UserMessages;
            yield return UserMissions;
            yield return UserMoney;
            yield return UserNetworth;
            yield return UserNewEvents;
            yield return UserNewMessages;
            yield return UserNotifications;
            yield return UserPerks;
            yield return UserPersonalStats;
            yield return UserProfile;
            yield return UserProperties;
            yield return UserPublicStatus;
            yield return UserRefills;
            yield return UserReports;
            yield return UserRevives;
            yield return UserRevivesFull;
            yield return UserSkills;
            yield return UserStocks;
            yield return UserTravel;
            yield return UserWeaponExp;
            yield return UserWorkStats;
        }
    }

    private UserSection () : base ("user") {
        UserAmmo = new (this, "ammo", AccessLevel.Minimal, typeof (AmmoRoot), typeof (Ammo));
        UserAttacks = new (this, "attacks", AccessLevel.Limited, typeof (UserAttacksRoot), typeof (UserAttack));
        UserAttacksFull = new (this, "attacksfull", AccessLevel.Limited, typeof (UserAttacksFullRoot), typeof (UserAttackFull));
        UserBars = new (this, "bars", AccessLevel.Minimal, typeof (BarsRoot), typeof (BarsRoot));
        UserBasic = new (this, "basic", AccessLevel.Public, typeof (UserBasic), typeof (UserBasic));
        UserBattleStats = new (this, "battlestats", AccessLevel.Limited, typeof (BattleStatsRoot), typeof (BattleStatsRoot));
        UserBazaar = new (this, "bazaar", AccessLevel.Limited, typeof (BazaarRoot), typeof (BazaarListing));
        UserCooldowns = new (this, "cooldowns", AccessLevel.Minimal, typeof (CooldownsRoot), typeof (CooldownsRoot));
        UserCriminalRecord = new (this, "criminalrecord", AccessLevel.Public, typeof (CrimeRecordRoot), typeof (CrimeRecordCollection));
        UserDiscord = new (this, "discord", AccessLevel.Limited, typeof (DiscordRoot), typeof (DiscordRecord));
        UserDisplay = new (this, "display", AccessLevel.Public, typeof (DisplayCaseRoot), typeof (DisplayCaseItem));
        UserEducation = new (this, "education", AccessLevel.Minimal, typeof (EducationRoot), typeof (EducationRoot));
        UserEquipment = new (this, "equipment", AccessLevel.Minimal, typeof (EquipmentRoot), typeof (EquipmentEntry));
        UserEvents = new (this, "events", AccessLevel.Limited, typeof (EventsRoot), typeof (Event));
        UserGym = new (this, "gym", AccessLevel.Minimal, typeof (GymRoot), typeof (GymRoot));
        UserHof = new (this, "hof", AccessLevel.Limited, typeof (HallOfFameRoot), typeof (HallOfFameRoot));
        UserHonors = new (this, "honors", AccessLevel.Minimal, typeof (HonorsRoot), typeof (HonorsRoot));
        UserIcons = new (this, "icons", AccessLevel.Public, typeof (IconsRoot), typeof (IconsRoot));
        UserJobPoints = new (this, "jobpoints", AccessLevel.Minimal, typeof (JobPointsRoot), typeof (JobPointsCollection));
        UserLog = new (this, "log", AccessLevel.Full, typeof (LogRoot), typeof (LogEntry));
        UserMedals = new (this, "medals", AccessLevel.Public, typeof (MedalsRoot), typeof (MedalsRoot));
        UserMerits = new (this, "merits", AccessLevel.Minimal, typeof (MeritsRoot), typeof (UserMerits));
        UserMessages = new (this, "messages", AccessLevel.Limited, typeof (MessagesRoot), typeof (UserMessage));
        UserMissions = new (this, "missions", AccessLevel.Minimal, typeof (MissionsRoot), typeof (MissionsRoot));
        UserMoney = new (this, "money", AccessLevel.Limited, typeof (MoneyRoot), typeof (MoneyRoot));
        UserNetworth = new (this, "networth", AccessLevel.Limited, typeof (NetworthRoot), typeof (NetworthRecord));
        UserNewEvents = new (this, "newevents", AccessLevel.Minimal, typeof (NewUserEventsRoot), typeof (NewUserEvent));
        UserNewMessages = new (this, "newmessages", AccessLevel.Minimal, typeof (NewUserMessagesRoot), typeof (UserMessage));
        UserNotifications = new (this, "notifications", AccessLevel.Minimal, typeof (UserNotificationsRoot), typeof (UserNotifications));
        UserPerks = new (this, "perks", AccessLevel.Minimal, typeof (PerksRoot), typeof (PerksRoot));
        UserPersonalStats = new (this, "personalstats", AccessLevel.Public, typeof (PersonalStatsRoot), typeof (PersonalStatsEntry));
        UserProfile = new (this, "profile", AccessLevel.Public, typeof (UserProfileRoot), typeof (UserProfileRoot));
        UserProperties = new (this, "properties", AccessLevel.Public, typeof (PropertiesRoot), typeof (UserProperty));
        UserPublicStatus = new (this, "publicstatus", AccessLevel.Public, typeof (PublicStatusRoot), typeof (PublicStatusRoot));
        UserRefills = new (this, "refills", AccessLevel.Minimal, typeof (RefillsRoot), typeof (RefillStates));
        UserReports = new (this, "reports", AccessLevel.Limited, typeof (UserReportsRoot), typeof (Report));
        UserRevives = new (this, "revives", AccessLevel.Minimal, typeof (UserRevivesRoot), typeof (Revive));
        UserRevivesFull = new (this, "revivesfull", AccessLevel.Minimal, typeof (UserReviveFullRoot), typeof (ReviveFull));
        UserSkills = new (this, "skills", AccessLevel.Minimal, typeof (SkillsRoot), typeof (SkillsRoot));
        UserStocks = new (this, "stocks", AccessLevel.Limited, typeof (UserStocksRoot), typeof (UserStock));
        UserTravel = new (this, "travel", AccessLevel.Minimal, typeof (TravelRoot), typeof (TravelEntry));
        UserWeaponExp = new (this, "weaponexp", AccessLevel.Minimal, typeof (WeaponExpRoot), typeof (WeaponExpEntry));
        UserWorkStats = new (this, "workstats", AccessLevel.Minimal, typeof (WorkStatsRoot), typeof (WorkStatsRoot));
    }
}