using Bartender.Net.Framework;
using Bartender.Net.User.Ammo;
using Bartender.Net.User.UserAttacks;
using Bartender.Net.User.UserAttacksFull;
using Bartender.Net.User.Bars;
using Bartender.Net.User.UserBasic;
using Bartender.Net.User.BattleStats;
using Bartender.Net.User.Cooldowns;
using Bartender.Net.User.Crimes;
using Bartender.Net.User.CriminalRecord;
using Bartender.Net.User.Discord;
using Bartender.Net.User.DisplayCase;
using Bartender.Net.User.Education;
using Bartender.Net.User.Equipment;
using Bartender.Net.User.Events;
using Bartender.Net.User.Gym;
using Bartender.Net.User.HallOfFame;
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
using Bartender.Net.User.NewUserEvents;
using Bartender.Net.User.NewUserMessages;
using Bartender.Net.User.UserNotifications;
using Bartender.Net.User.Perks;
using Bartender.Net.User.PersonalStats;
using Bartender.Net.User.UserProfile;
using Bartender.Net.User.Properties;
using Bartender.Net.User.PublicStatus;
using Bartender.Net.User.Refills;
using Bartender.Net.User.Skills;
using Bartender.Net.User.UserStocks;
using Bartender.Net.User.Travel;
using Bartender.Net.User.WeaponExp;
using Bartender.Net.User.WorkStats;
using Bartender.Net.User.Ammunition;
using Bartender.Net.User.Attacks;
using Bartender.Net.User.AttacksFull;
using Bartender.Net.User.Basic;
using Bartender.Net.User.CrimeRecord;
using Bartender.Net.User.Social;
using Bartender.Net.User.HoF;
using Bartender.Net.User.NewEvents;
using Bartender.Net.User.NewMessages;
using Bartender.Net.User.Notifications;
using Bartender.Net.User.Profile;
using Bartender.Net.User.Property;
using Bartender.Net.User.Stocks;

namespace Bartender.Net.User;

public class UserOverview : IBartenderEntity {
    public required int ID { get; set; }

    public required AmmoRoot Ammo { get; set; }

    public required UserAttacksRoot UserAttacks { get; set; }

    public required UserAttacksFullRoot UserAttacksFull { get; set; }

    public required BarsRoot Bars { get; set; }

    public required UserBasic UserBasic { get; set; }

    public required BattleStatsRoot BattleStats { get; set; }

    public required CooldownsRoot Cooldowns { get; set; }

    public required CrimesRoot Crimes { get; set; }

    public required CriminalRecordRoot CriminalRecord { get; set; }

    public required DiscordRoot Discord { get; set; }

    public required DisplayCaseRoot DisplayCase { get; set; }

    public required EducationRoot Education { get; set; }

    public required EquipmentRoot Equipment { get; set; }

    public required EventsRoot Events { get; set; }

    public required GymRoot Gym { get; set; }

    public required HallOfFameRoot HallOfFame { get; set; }

    public required HonorsRoot Honors { get; set; }

    public required IconsRoot Icons { get; set; }

    public required JobPointsRoot JobPoints { get; set; }

    public required LogRoot Log { get; set; }

    public required MedalsRoot Medals { get; set; }

    public required MeritsRoot Merits { get; set; }

    public required MessagesRoot Messages { get; set; }

    public required MissionsRoot Missions { get; set; }

    public required MoneyRoot Money { get; set; }

    public required NetworthRoot Networth { get; set; }

    public required NewUserEventsRoot NewUserEvents { get; set; }

    public required NewUserMessagesRoot NewUserMessages { get; set; }

    public required UserNotificationsRoot UserNotifications { get; set; }

    public required PerksRoot Perks { get; set; }

    public required PersonalStatsRoot PersonalStats { get; set; }

    public required UserProfileRoot UserProfile { get; set; }

    public required PropertiesRoot Properties { get; set; }

    public required PublicStatusRoot PublicStatus { get; set; }

    public required RefillsRoot Refills { get; set; }

    public required SkillsRoot Skills { get; set; }

    public required UserStocksRoot UserStocks { get; set; }

    public required TravelRoot Travel { get; set; }

    public required WeaponExpRoot WeaponExp { get; set; }

    public required WorkStatsRoot WorkStats { get; set; }
}
