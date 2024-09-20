using Bartender.Net.User.Ammunition;
using Bartender.Net.User.Attacks;
using Bartender.Net.User.AttacksFull;
using Bartender.Net.User.Bars;
using Bartender.Net.User.Basic;
using Bartender.Net.User.BattleStats;
using Bartender.Net.User.Cooldowns;
using Bartender.Net.User.CrimeRecord;
using Bartender.Net.User.Crimes;
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
using Bartender.Net.User.Social;
using Bartender.Net.User.Stocks;
using Bartender.Net.User.Travel;
using Bartender.Net.User.WeaponExp;
using Bartender.Net.User.WorkStats;

namespace Bartender.Net.User;

public record UserOverview (AmmoRoot? Ammo = null,
                            UserAttacksRoot? UserAttacks = null,
                            UserAttacksFullRoot? UserAttacksFull = null,
                            BarsRoot? Bars = null,
                            UserBasic? UserBasic = null,
                            BattleStatsRoot? BattleStats = null,
                            CooldownsRoot? Cooldowns = null,
                            CrimesRoot? Crimes = null,
                            CriminalRecordRoot? CriminalRecord = null,
                            DiscordRoot? Discord = null,
                            DisplayCaseRoot? DisplayCase = null,
                            EducationRoot? Education = null,
                            EquipmentRoot? Equipment = null,
                            EventsRoot? Events = null,
                            GymRoot? Gym = null,
                            HallOfFameRoot? HallOfFame = null,
                            HonorsRoot? Honors = null,
                            IconsRoot? Icons = null,
                            JobPointsRoot? JobPoints = null,
                            LogRoot? Log = null,
                            MedalsRoot? Medals = null,
                            MeritsRoot? Merits = null,
                            MessagesRoot? Messages = null,
                            MissionsRoot? Missions = null,
                            MoneyRoot? Money = null,
                            NetworthRoot? Networth = null,
                            NewUserEventsRoot? NewUserEvents = null,
                            NewUserMessagesRoot? NewUserMessages = null,
                            UserNotificationsRoot? UserNotifications = null,
                            PerksRoot? Perks = null,
                            PersonalStatsRoot? PersonalStats = null,
                            UserProfileRoot? UserProfile = null,
                            PropertiesRoot? Properties = null,
                            PublicStatusRoot? PublicStatus = null,
                            RefillsRoot? Refills = null,
                            UserReportsRoot? Reports = null,
                            UserRevivesRoot? Revives = null,
                            UserReviveFullRoot? ReviveFull = null,
                            SkillsRoot? Skills = null,
                            UserStocksRoot? UserStocks = null,
                            TravelRoot? Travel = null,
                            WeaponExpRoot? WeaponExp = null,
                            WorkStatsRoot? WorkStats = null);
